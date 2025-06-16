namespace KursInfosys.Components.Pages.Modul4
{
    public class ChatVM
    {
        public List<ChatModel> ChatList { get; set; } = new();
        public event Action OnAdd;
        public void AddMessage(string msg)
        {
            
                ChatList.Add(new ChatModel { Name="fake",Message=msg});
               OnAdd?.Invoke();
        }
    }
}
