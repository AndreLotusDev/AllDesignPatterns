namespace SimpleExample.Classes
{
    /// <summary>
    /// Do complex stuff
    /// </summary>
    public class SerasaHandler
    {
        private string[] Name = { "Joao", "Silva", "Andre", "Barbara", "Luna", "Thiago", "Julia", "Silva" };

        public bool IsInadiplent(string name)
        {
            if (Name.Any(a => a.ToLower().Contains(name)))
            {
                throw new Exception("This name is inadiplent, is not possible to complete the transaction");
            }

            return false;
        }
    }
}
