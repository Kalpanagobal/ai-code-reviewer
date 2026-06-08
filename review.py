from groq import Groq
import os

client = Groq(
    api_key=os.getenv("GROQ_API_KEY")
)

with open("Program.cs", "r") as f:
    code = f.read()

prompt = f"""
Review this C# code.

Return ONLY valid JSON.

Format:

{{
  "issues": [
    {{
      "severity": "High/Medium/Low",
      "issue": "Issue Name",
      "suggestion": "Fix"
    }}
  ]
}}

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
