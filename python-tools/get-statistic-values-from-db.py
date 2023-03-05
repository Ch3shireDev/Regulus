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

cursor = conn.cursor()

query = 'SELECT A1,A2,A3 FROM DATA_ROWS WHERE SPECIES = \'PAR.CAE\''

values = cursor.execute(query)

data = cursor.fetchall()

a1 = [int(x[0]) for x in data]
a2 = [int(x[1]) for x in data]
a3 = [int(x[2]) for x in data]

a1_mean = sum(a1) / len(a1)
a2_mean = sum(a2) / len(a2)
a3_mean = sum(a3) / len(a3)

print(a1_mean)
print(a2_mean)
print(a3_mean)

conn.commit()

conn.close()
