import re

file_path = r"D:\VsStudio\thuc-tap-chuyen-nganh\WinFormsAppTest\Dashboard.Designer.cs"

with open(file_path, 'r', encoding='utf-8') as f:
    content = f.read()

# Remove ImageAlign lines
content = re.sub(r'\s*btnMenu\w+\.ImageAlign = ContentAlignment\.MiddleLeft;', '', content)

# Remove TextAlign lines
content = re.sub(r'\s*btnMenu\w+\.TextAlign = ContentAlignment\.MiddleLeft;', '', content)

with open(file_path, 'w', encoding='utf-8') as f:
    f.write(content)

print("Done! Removed ImageAlign and TextAlign properties.")
