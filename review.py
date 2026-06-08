from groq import Groq
import os

client = Groq(
    api_key=os.getenv("GROQ_API_KEY")
)

response = client.chat.completions.create(
    model="llama-3.3-70b-versatile",
    messages=[
        {
            "role": "user",
            "content": """
Review this C# code and tell me the issues:

string name = null;
Console.WriteLine(name.Length);
"""
        }
    ]
)

print(response.choices[0].message.content)
