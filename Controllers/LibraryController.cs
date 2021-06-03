namespace CodeLibrary.Controllers
{

    class LibraryController
    {
        private bool _running { get; set; }
        public void run()
        {
            while (_running)
            {
                InitUserInput();
            }
        }

        private void InitUserInput()
        {
            System.Console.WriteLine("Choices: Add, Info, Checkout, Return, Delete, Quit ");

            string choice = System.Console.ReadLine();

            switch (choice)
            {
                case "Add":
                    Add();
                    break;
                case "Info":
                    Info();
                    break;
                case "Checkout":
                    Checkout();
                    break;
                case "Return":
                    Return();
                    break;
                case "Delete":
                    Delete();
                    break;
                case "Quit":
                    Quit();
                    break;

                default:
                    System.Console.WriteLine("Invalid Command");
                    break;
            }
        }

        private void Add()
        {

        }

        private void Info()
        {

        }

        private void Checkout()
        {

        }

        private void Return()
        {

        }

        private void Delete()
        {

        }

        private void Quit()
        {

        }

    }


}