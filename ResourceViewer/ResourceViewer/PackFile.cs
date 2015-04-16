using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ResourceViewer {
	struct FileData {
		public int offset;
		public int size;
		public int i3;
		public string filename;


		public override bool Equals(object b) {
			if (b is FileData) {
				return (this.i3 == ((FileData)b).i3) && (this.size == ((FileData)b).size);
			}

			return false;
		}

		public override int GetHashCode() {
 			 return base.GetHashCode();
		}

	}

	class PackFile {
		public int header;
		public Dictionary<String, FileData> Files = new Dictionary<string, FileData>();
		public string FileName;

		public PackFile(string filename) {
			this.FileName = filename;

			using (FileStream s = File.Open(filename, FileMode.Open, FileAccess.Read))
			using (BinaryReader reader = new BEBinaryReader(s)) {
				while (true) {

					header = reader.ReadInt32();
					//if (header == 0) break;
					int files = reader.ReadInt32();
					//packData.header.i3 = reader.ReadInt32();
					if (files == 0) break;

					for (int i = 0; i < files; i++) {
						string readName = reader.ReadString();

						FileData fileDat = new FileData();
						fileDat.offset = reader.ReadInt32();
						fileDat.size = reader.ReadInt32();
						fileDat.i3 = reader.ReadInt32();
						fileDat.filename = filename;

						Files.Add(readName, fileDat);
					}
				}

			}
		}

		public byte[] GetFile(string fileName) {

			if (!Files.Keys.Contains(fileName))
				return null;

			FileData fData = Files[fileName];

			using (FileStream s = File.Open(FileName, FileMode.Open, FileAccess.Read))
			using (BinaryReader reader = new BEBinaryReader(s)) {
				s.Seek(fData.offset, SeekOrigin.Begin);
				byte[] file = reader.ReadBytes(fData.size);
				return file;
			}

		}

		public void Extract(string fileName, string directory) {

			if (!Files.Keys.Contains(fileName))
				return;

			FileData fData = Files[fileName];

			using (FileStream s = File.Open(FileName, FileMode.Open, FileAccess.Read))
			using (BinaryReader reader = new BEBinaryReader(s))
			using (FileStream outfile = File.Open(directory + Path.DirectorySeparatorChar + fileName, FileMode.Create, FileAccess.Write)) {
				s.Seek(fData.offset, SeekOrigin.Begin);
				byte[] file = reader.ReadBytes(fData.size);
				outfile.Write(file, 0, file.Length);
			}
		}

		public void Extract(string directory) {
			using (FileStream s = File.Open(FileName, FileMode.Open, FileAccess.Read))
			using (BinaryReader reader = new BEBinaryReader(s))

			foreach (KeyValuePair<String, FileData> entry in Files) {

				using (FileStream outfile = File.Open(directory + Path.DirectorySeparatorChar + entry.Key, FileMode.Create, FileAccess.Write)) {
					s.Seek(entry.Value.offset, SeekOrigin.Begin);
					byte[] file = reader.ReadBytes(entry.Value.size);
					outfile.Write(file, 0, file.Length);
				}
			}
		}
	}
}
