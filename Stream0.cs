using System;
using System.IO;

// Token: 0x020000E1 RID: 225
internal sealed class Stream0 : Stream
{
	// Token: 0x060005DB RID: 1499 RVA: 0x00005F54 File Offset: 0x00004154
	public Stream0(Stream stream_1, int int_1)
	{
		this.method_1(stream_1);
		this.int_0 = int_1;
	}

	// Token: 0x060005DC RID: 1500 RVA: 0x00005F6A File Offset: 0x0000416A
	public Stream method_0()
	{
		return this.stream_0;
	}

	// Token: 0x060005DD RID: 1501 RVA: 0x00005F72 File Offset: 0x00004172
	private void method_1(Stream stream_1)
	{
		this.stream_0 = stream_1;
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x060005DE RID: 1502 RVA: 0x00005F7B File Offset: 0x0000417B
	public override bool CanRead
	{
		get
		{
			return this.method_0().CanRead;
		}
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x060005DF RID: 1503 RVA: 0x00005F88 File Offset: 0x00004188
	public override bool CanSeek
	{
		get
		{
			return this.method_0().CanSeek;
		}
	}

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x060005E0 RID: 1504 RVA: 0x00005F95 File Offset: 0x00004195
	public override bool CanWrite
	{
		get
		{
			return this.method_0().CanWrite;
		}
	}

	// Token: 0x060005E1 RID: 1505 RVA: 0x00005FA2 File Offset: 0x000041A2
	public override void Flush()
	{
		this.method_0().Flush();
	}

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x060005E2 RID: 1506 RVA: 0x00005FAF File Offset: 0x000041AF
	public override long Length
	{
		get
		{
			return this.method_0().Length;
		}
	}

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x060005E3 RID: 1507 RVA: 0x00005FBC File Offset: 0x000041BC
	// (set) Token: 0x060005E4 RID: 1508 RVA: 0x00005FC9 File Offset: 0x000041C9
	public override long Position
	{
		get
		{
			return this.method_0().Position;
		}
		set
		{
			this.method_0().Position = value;
		}
	}

	// Token: 0x060005E5 RID: 1509 RVA: 0x000351D0 File Offset: 0x000333D0
	private byte method_2(byte byte_0, long long_0)
	{
		byte b = (byte)((ulong)this.int_0 | (ulong)long_0);
		return byte_0 ^ b;
	}

	// Token: 0x060005E6 RID: 1510 RVA: 0x000351EC File Offset: 0x000333EC
	public override void Write(byte[] buffer, int offset, int count)
	{
		byte[] array = new byte[count];
		Buffer.BlockCopy(buffer, offset, array, 0, count);
		long position = this.Position;
		for (int i = 0; i < count; i++)
		{
			array[i] = this.method_2(array[i], position + (long)i);
		}
		this.method_0().Write(array, 0, count);
	}

	// Token: 0x060005E7 RID: 1511 RVA: 0x0003523C File Offset: 0x0003343C
	public override int Read(byte[] buffer, int offset, int count)
	{
		long position = this.Position;
		byte[] array = new byte[count];
		int num = this.method_0().Read(array, 0, count);
		for (int i = 0; i < num; i++)
		{
			buffer[i + offset] = this.method_2(array[i], position + (long)i);
		}
		return num;
	}

	// Token: 0x060005E8 RID: 1512 RVA: 0x00005FD7 File Offset: 0x000041D7
	public override long Seek(long offset, SeekOrigin origin)
	{
		return this.method_0().Seek(offset, origin);
	}

	// Token: 0x060005E9 RID: 1513 RVA: 0x00005FE6 File Offset: 0x000041E6
	public override void SetLength(long value)
	{
		this.method_0().SetLength(value);
	}

	// Token: 0x040002D3 RID: 723
	private readonly int int_0;

	// Token: 0x040002D4 RID: 724
	private Stream stream_0;
}
