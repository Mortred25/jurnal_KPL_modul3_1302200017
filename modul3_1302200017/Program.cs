namespace modul3_1302200017
{
    class program
    {

        static void Main(string[] args)
        {
            KodeBuah table_Kodebuah = new KodeBuah();
            Console.WriteLine("=== GET KODE BUAH ===");
            table_Kodebuah.getKodeBuah();

            Console.WriteLine("==== State Awal ====");
            PosisiKarakterGame game = new PosisiKarakterGame();
            game.tombol();
        }
    }

    class KodeBuah
    {
        Dictionary<string, string> dic = new Dictionary<string, string>()
        {
            {"Apel", "A00"},
            {"Aprikot", "B00"},
            {"Alpukat", "C00"},
            {"Pisang", "D00"},
            {"Paprika", "E00"},
            {"Blackberry", "F00"},
            {"Ceri", "H00"},
            {"Kelapa", "I00"},
            {"Jagung", "J00"},
            {"Kurma", "K00"},
            {"Durian", "L00"},
            {"Anggur", "M00"},
            {"Melon", "N00"},
            {"Semangka", "O00"}


        };
        public void getKodeBuah()
        {
            foreach (KeyValuePair<string, string> ele1 in dic)
            {
                Console.WriteLine("{0} \t {1}", ele1.Key, ele1.Value);
            }
        }
    }
    class PosisiKarakterGame
    {
        enum State { Berdiri, Jongkok, Berdiri2 };
        public void tombol()
        {
            State state = State.Berdiri;

            String[] screenName = { "Berdiri", "posisi standby", "posisi istirahat" };
            do
            {
                Console.WriteLine("" + screenName[(int)state]);
                Console.Write("Tekan Tombol : ");
                String command = Console.ReadLine();
                switch (state)
                {
                    case State.Berdiri:
                        if (command == "Berdiri")
                        {
                            state = State.Jongkok;
                        }
                        break;
                    case State.Jongkok:
                        if (command == "Tengkurap")
                        {
                            state = State.Berdiri2;
                        }
                        break;
                    case State.Berdiri2:
                        if (command == "Stop")
                        {
                            state = State.Berdiri;
                        }
                        break;
                }
            } while (state != State.Berdiri);
        }
    }
}