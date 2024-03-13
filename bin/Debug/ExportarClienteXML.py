import psycopg2
import xml.etree.ElementTree as ET
import conectionExportarClass as cec

class exportarClienteHotel(cec.conexionSQL):

    def __init__(self,*args,**kwargs):
        super().__init__(*args,**kwargs)
        self.exportarCliente()
    # Conexión a PostgreSQL
    def exportarCliente(self):
        conn_pg = psycopg2.connect(database=self.database, user=self.user, password=self.password, host=self.host)
        cursor_pg = conn_pg.cursor()

        # Consulta SQL para recuperar datos de PostgreSQL
        sql_query = "SELECT * FROM cliente"
        cursor_pg.execute(sql_query)
        rows = cursor_pg.fetchall()

        # Crear un elemento raíz XML
        root = ET.Element("data")

        # Iterar sobre los registros y crear elementos XML
        for row in rows:
            record = ET.SubElement(root, "record")
            for index, column_value in enumerate(row):
                field_name = cursor_pg.description[index][0]
                field = ET.SubElement(record, field_name)
                field.text = str(column_value)

        # Guardar el archivo XML
        tree = ET.ElementTree(root)
        tree.write("clienteExportar.xml")

        # Cerrar la conexión a PostgreSQL
        conn_pg.close()


