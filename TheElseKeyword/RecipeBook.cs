namespace TheElseKeyword
{
    public class RecipeBook
    {
        private readonly Dictionary<string, Action> _recipes;
        private readonly Func<string> _inputProvider;
        private readonly Action<string> _outputProvider;
        public RecipeBook(Func<string> inputProvider, Action<string> outputProvider)
        {
            _inputProvider = inputProvider;
            _outputProvider = outputProvider;
            _recipes = new Dictionary<string, Action>
            {
                {"beer", ServeBeer},
                {"juice", ServeJuice}
            };
        }

        public void MakeDrink(string name)
        {
            _recipes[name]();
        }

        public IEnumerable<string> GetAvailableDrinkNames()
        {
            return _recipes.Keys;
        }

        private void UnavailableDrink(string drink)
        {
            _outputProvider($"Sorry, mate but we don't do {drink}");
        }

        private void ServeJuice()
        {
            _outputProvider("Here you go! Fresh and nice juice.");
        }

        private void ServeBeer()
        {
            _outputProvider("Not so fast cowboy. How old are you?");

            if (!int.TryParse(_inputProvider(), out var age))
            {
                HandleInvalidAge();
                return;
            }

            HandleBeerAgeCheck(age);
        }

        private void HandleBeerAgeCheck(int age)
        {
            _outputProvider(age >= 18
                ? "Here you go! Cold beer."
                : "Sorry, but you're not old enough to drink (in the UK)");
        }

        private void HandleInvalidAge()
        {
            _outputProvider("Could not parse the age provided");
        }
    }
}
