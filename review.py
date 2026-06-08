from groq import Groq
import os

client = Groq(
    api_key=os.getenv("GROQ_API_KEY")
)

with open("Program.cs", "r") as f:
    code = f.read()

prompt = f"""
Review this C# code.

Find:
1. Bugs
2. Security Issues
3. Performance Issues

Code:

{code}
"""

response = client.chat.completions.create(
    model="llama-3.3-70b-versatile",
    messages=[
        {
            "role": "user",
            "content": prompt
        }
    ]
)

print(response.choices[0].message.content)
