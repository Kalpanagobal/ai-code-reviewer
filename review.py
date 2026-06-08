from groq import Groq
import os
import json

client = Groq(
    api_key=os.getenv("GROQ_API_KEY")
)

# Read C# code
with open("Program.cs", "r") as f:
    code = f.read()

# Prompt
prompt = f"""
Review this C# code.

Return ONLY raw JSON.
Do not use markdown.
Do not use ```json.
Do not provide explanations outside JSON.

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

# Call Groq
response = client.chat.completions.create(
    model="llama-3.3-70b-versatile",
    messages=[
        {
            "role": "user",
            "content": prompt
        }
    ]
)

# Get response
review_result = response.choices[0].message.content

# Clean markdown if present
review_result = review_result.replace("```json", "")
review_result = review_result.replace("```", "")
review_result = review_result.strip()

# Validate JSON
try:
    json.loads(review_result)

    with open("review.json", "w") as f:
        f.write(review_result)

    print("Review JSON generated successfully")
    print(review_result)

except json.JSONDecodeError as e:
    print("Invalid JSON returned by AI")
    print(review_result)
    raise e
