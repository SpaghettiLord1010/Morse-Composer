namespace MorseComposer.Data
{
    public class DataContext
	{
        public MessageData Message { get; private set; }


        public DataContext()
        {
            Message = new MessageData();
        }

	}
}
