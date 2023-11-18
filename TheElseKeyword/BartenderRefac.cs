namespace TheElseKeyword
{
    public class BartenderRefac
    {
        private readonly Func<string> _inputProvider;
        private readonly Action<string> _outputProvider;
        private readonly RecipeBook _recipeBook;

        public BartenderRefac(Func<string> inputProvider, Action<string> outputProvider, RecipeBook recipeBook)
        {
            _inputProvider = inputProvider;
            _outputProvider = outputProvider;
            _recipeBook = recipeBook;
        }

        public void AskForDrink()
        {
            _outputProvider($"What drink to you want? ({string.Join(", ", _recipeBook.GetAvailableDrinkNames())})");

            var drink = _inputProvider() ?? string.Empty;

            if(!_recipeBook.GetAvailableDrinkNames().Where(x => x.Contains(drink)) .Contains( drink ))
            {
                _outputProvider("Sorry I don't know how to make this one.");
                return;
            }

            _recipeBook.MakeDrink(drink);
        }
    }
}
