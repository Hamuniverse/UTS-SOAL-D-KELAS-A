using System;
class program
{
    public void main(string[] args)
    {
        Console.WriteLine("1. Lihat Saldo");
        Console.WriteLine("2. Tarik Tunai");
        Console.WriteLine("3. Setor Tunai");
        Console.WriteLine("4. Transfer Antar Rekening");
        Console.WriteLine("5. Keluar");
        Console.WriteLine("SILAHKAN PILIH MENU");
    }

    class menu
    {
        private string NamaNasabah;
        private string NoRekening;
        private double Saldo;
    }
}