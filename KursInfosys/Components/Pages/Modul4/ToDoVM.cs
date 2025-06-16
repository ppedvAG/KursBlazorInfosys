namespace KursInfosys.Components.Pages.Modul4
{
    public class ToDoVM
    {
        public TodoModel ToDo;
        public ToDoVM(IHttpClientFactory _http)
        {
            using (var client = _http.CreateClient())
            {
              
                    ToDo = client.GetFromJsonAsync<TodoModel>("https://dummyjson.com/todos?limit=300").Result;
         

            }


        }
    }
}
