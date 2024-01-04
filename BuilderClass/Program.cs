namespace BuilderClass;

class Pogram
{
    static void Main(string[] args)
    {
        Console.WriteLine(
            new BuilderClass().Name("Luan").NickNameConfig(x => x.Name = "Teste").LastName("Santos").CompletName());
    }
}

class BuilderClass
{
    private string _name;
    private string _nickName;
    private string _lastNmae;
    
    public BuilderClass Name(string name)
    {
        _name = name;
        return this;
    }

    public BuilderClass NickName(string nickName)
    {
        _nickName = nickName;
        return this;
    }

    public BuilderClass NickNameConfig(Action<ConfigName> config)
    {
        var configuration = new ConfigName();
        config?.Invoke(configuration);
        _nickName = configuration.Name;
        return this;
    }

    public BuilderClass LastName(string lastName)
    {
        _lastNmae = lastName;
        return this;
    }

    public string CompletName()
    {
        return $"{_name} {_nickName} {_lastNmae}";
    }

    public class ConfigName()
    {
        public string Name { get; set; }
    }
}