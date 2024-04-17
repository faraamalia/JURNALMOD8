using System;
using System.Text.Json;

class BankTransferConfig
{
	public string lang { get; set; }
	public Transfer transfer { get;set; } 
	public List<string> method { get; set; }
	public Confirmation confirmation { get; set; }



	public BankTransferConfig()
	{
	}
	
	public BankTransferConfig(string lang, Transfer transfer, List<string> method,Confirmation confirmation )
    {
        this.transfer = transfer;
        this.lang = lang;
        this.method = method;
        this.confirmation = confirmation;
    }

    class BankConfig
    {
        public BankTransferConfig config;
        public const string filepath = @"bank_transfer_config.json";
        public BankConfig()
        {
            try
            {
                ReadKonfigFile();
            }
            catch (Exception)
            {
                setDefault();
                WriteKonfigFile();
            }
        }
        private BankTransferConfig ReadConfigFile()
        {
            String configJsonData = File.ReadAllText(filepath);
            config = JsonSerializer.Deserialize<BankTransferConfig>(configJsonData);
            return config;
        }
        private void WriteNewConfigFile()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            String jsonString = JsonSerializer.Serialize(config, options);
            File.WriteAllText(filepath, jsonString);

        }
    }

    

}

public class Transfer
{
    public int threshold;
    public int low_fee;
    public int high_fee;
}


public class Confirmation
{
    public Confirmation()
    {

    public string en;
    public string id;
}

