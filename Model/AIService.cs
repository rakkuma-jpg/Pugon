using System.Diagnostics;
using OllamaSharp;
using OllamaSharp.Models.Chat;

namespace Pugon.Model;
public class LlamaEngine
{
	private readonly OllamaApiClient _client;
	private readonly List<Message> _history = new();

    public LlamaEngine()
    {
        string url;

#if ANDROID
        url = "http://127.0.0.1:11434";
        //url = "http://192.168.254.122:11434";
#else
        url = "http://localhost:11434";
#endif

        _client = new OllamaApiClient(url);
        Debug.WriteLine("USING URL: " + url);


        _history.Add(new Message
        {
            Role = "system",
            Content = "Your name is TinapAI, " +
            "You are a helpful AI assistant that guides the user to bake pastry, " +
            "especially/striclty for filipino pastries only. Please answer our user with respectfully and kindness.. " +
            "greet the user with your short description of yourself no matter what the user first input. " +
            "keep your answer short, " +
            "also keep the text be optimize on phones especially the use of spacing"
        });

        //_history.Add(new Message("system", "Your name is TinapAI, You are a helpful AI assistant that guides the user to bake pastry, especially filipino pastry. Please answer our user with respectfully and kindness.. greet the user with your short description of yourself no matter what the user first input. keep your answer short, also keep the text be optimize on phones especially the use of spacing"));
    }


    // handle network errors inside AskAsync
    public async Task<string> AskAsync(string prompt)
    {
        _history.Add(new Message
        {
            Role = "user",
            Content = prompt
        });

        var request = new ChatRequest { Model = "llama3", Messages = _history };
        string reply = "";

        try
        {
            await foreach (var chunk in _client.ChatAsync(request))
            {
                if (chunk?.Message?.Content != null)
                    reply += chunk.Message.Content;
            }
        }
        catch (HttpRequestException ex)
        {
            Debug.WriteLine("Ollama connection failed: " + ex.ToString());
            return "Unable to connect to the AI server.";
        }

        _history.Add(new Message
        {
            Role = "assistant",
            Content = reply
        });

        return reply;
    }
}