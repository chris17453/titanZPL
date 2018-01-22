using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace titanZPL{
    public class lz77 {
        public static MemoryStream Decompress(Stream input) {
	        BinaryReader reader = new BinaryReader(input);                                  // Check LZ77 type.
	        if (reader.ReadByte() != 0x10) throw new ArgumentException("Input stream does not contain LZ77-compressed data.", "input");
	        int size = reader.ReadUInt16() | (reader.ReadByte() << 16);                     // Read the size.
	        MemoryStream output = new MemoryStream(size);                                   // Create output stream.
	        while (output.Length < size) {                                                  // Begin decompression.
		        int flagByte = reader.ReadByte();                                           // Load flags for the next 8 blocks.
		        for (int i = 0; i < 8; i++) {                                               // Process the next 8 blocks.
			        if ((flagByte & (0x80 >> i)) == 0) {                                    // Check if the block is compressed.
				        output.WriteByte(reader.ReadByte());                                // Uncompressed block; copy single byte.
			        } else {                                                                // Compressed block; read block.
				        ushort block = reader.ReadUInt16();
				        int count = ((block >> 4) & 0xF) + 3;                               // Get byte count.
				        int disp = ((block & 0xF) << 8) | ((block >> 8) & 0xFF);            // Get displacement.
				        long outPos = output.Position;                                      // Save current position and copying position.
				        long copyPos = output.Position - disp - 1;
				        for (int j = 0; j < count; j++) {                                   // Copy all bytes.
					        output.Position = copyPos++;                                    // Read byte to be copied.
					        byte b = (byte)output.ReadByte();
					        output.Position = outPos++;                                     // Write byte to be copied.
					        output.WriteByte(b);
				        }
			        }
			        if (output.Length >= size) {                                            // If all data has been decompressed, stop.
				        break;
			        }
		        }
	        }
	        output.Position = 0;
	        return output;
        }
    }
}
