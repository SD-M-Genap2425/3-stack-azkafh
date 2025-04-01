using System;

namespace Solution.BrowserHistory
{
    public class Halaman
    {
        public string URL { get; }

        public Halaman(string url)
        {
            URL = url;
        }
    }

    public class HistoryManager
    {
        private class Node
        {
            public Halaman Halaman { get; set; }
            public Node? Next { get; set; }

            public Node(Halaman halaman)
            {
                Halaman = halaman;
                Next = null;
            }
        }

        private Node? top;

        public HistoryManager()
        {
            top = null;
        }

        public void KunjungiHalaman(string url)
        {
            Halaman halamanBaru = new Halaman(url);
            Node newNode = new Node(halamanBaru);
            newNode.Next = top;
            top = newNode;
            Console.WriteLine($"Mengunjungi halaman: {url}");
        }

        public string Kembali()
        {
            if (top == null)
            {
                return "Tidak ada halaman sebelumnya.";
            }

            string urlSebelumnya = top.Halaman.URL;
            top = top.Next;
            return top != null ? top.Halaman.URL : "Tidak ada halaman sebelumnya.";
        }

        public string LihatHalamanSaatIni()
        {
            return top != null ? top.Halaman.URL : null;
        }

        public void TampilkanHistory()
        {
            Stack<string> historyList = new Stack<string>();
            Node current = top;

            while (current != null)
            {
                historyList.Push(current.Halaman.URL);
                current = current.Next;
            }

            while (historyList.Count > 0)
            {
                Console.WriteLine(historyList.Pop());
            }

        }
    }
}