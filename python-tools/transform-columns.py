import re

input_lines = open('columns.txt', 'r', encoding='utf-8').readlines()

output = open('output.txt', 'w', encoding='utf-8')

for line in input_lines:
    line = line.strip()
    words = line.split()

    from_index = 1
    if words[1] == 'f.':
        from_index = 2

    if re.match(r'\d+', words[from_index]):
        from_index += 1

    if words[from_index] == 'RS':
        from_index += 1
    if words[from_index] == 'LS':
        from_index += 1

    field_description = " ".join(words[from_index:])

    column_name = ' '.join(words[:from_index])

    # capitalize first letter if is not upper
    for i in range(from_index):
        if not words[i].isupper():
            words[i] = words[i][0].upper() + words[i][1:]

    field_name = "".join([w for w in words[:from_index]])
    field_name = re.sub(r'[\-\.]', '_', field_name)
    field_name = field_name.replace('!', 'Confirm')
    field_name = field_name.replace('?', 'Question')
    # capitalize after number
    field_name = re.sub(r'(\d)(rs)', r'\1RS', field_name)
    field_name = re.sub(r'(\d)(ls)', r'\1LS', field_name)
    field_name = re.sub(r'F_(\d)', r'F\1', field_name)
    # field_name = field_name.split('_')
    # field_name = "".join([w.capitalize() for w in field_name])


    csharp_struct = f'///<summary>\n/// {field_description}.\n///</summary>\n[Name("{column_name}")]\npublic string? {field_name}{{get;set;}}'
    print(csharp_struct, file=output)
