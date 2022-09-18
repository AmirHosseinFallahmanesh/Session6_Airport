namespace Part3
{
    interface ISender
    {
        void Send(string destination, string title, string body);
        public int Port { get; set; }
        public string Source { get;  }
    }
}
