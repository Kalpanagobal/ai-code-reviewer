import json

with open("review.json", "r") as f:
    data = json.load(f)

issues = data.get("issues", [])

summary = f"""
AI Review Summary

Total Issues: {len(issues)}

"""

for issue in issues:
    summary += f"- [{issue['severity']}] {issue['issue']}\n"

with open("summary.txt", "w") as f:
    f.write(summary)

print(summary)
