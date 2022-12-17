public class DataTableCryptographer
{
    protected virtual uint XOROperand
    {
        get
        {
            return 68113U;
        }
    }

    public int DecryptInt32(byte[] datas)
    {
        return BitConverter.ToInt32(this.ToXORByteArray(datas), 0);
    }

    public float DecryptFloat(byte[] datas)
    {
        return BitConverter.ToSingle(this.ToXORByteArray(datas), 0);
    }

    private byte[] ToXORByteArray(byte[] arrayValue)
    {
        if (arrayValue == null || arrayValue.Length <= 0)
        {
            return new byte[0];
        }
        byte[] array = new byte[arrayValue.Length];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = (byte)((uint)arrayValue[i] ^ this.XOROperand);
        }
        return array;
    }

    public static int CRPTO_BYTE_COUNT = 16;
}
