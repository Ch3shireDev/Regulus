import pyodbc
import random
import string

# Connect to Access database
conn_str = (
r'Driver={Microsoft Access Driver (*.mdb, *.accdb)};'+\
r'DBQ=./testdb1.accdb;'
)
conn = pyodbc.connect(conn_str, autocommit=False)

# Define values for columns
species = ['PAR.CAE', 'ERI.RUB', 'PRU.MOD']
field_chars = string.ascii_letters + string.digits
field_length = 10

# Write records to database
cursor = conn.cursor()
for i in range(1,2000001):
    values = {}
    values['ID'] = i
    values['SPECIES'] = random.choice(species)
    # Generate random values for each column

    for j in range(1, 12):
        values['A{}'.format(j)] =  random.randint(1, 11)

    for j in range(1, 21):
        values['Field{}'.format(j)] = ''.join(
            random.choice(field_chars) for _ in range(field_length)
        )

    # Insert record into database
    columns = ', '.join(values.keys())
    placeholders = ', '.join('?' for _ in values)

    
    query = 'INSERT INTO DATA_ROWS ({}) VALUES ({})'.format(columns, placeholders)


    cursor.execute(query, *values.values())

    # Commit every 1000 records
    if i % 1000 == 0:
        print('commit', i)
        conn.commit()

conn.commit()
conn.close()