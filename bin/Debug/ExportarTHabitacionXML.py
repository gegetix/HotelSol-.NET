import psycopg2
import xml.etree.ElementTree as ET
import conectionExportarClass as cec

class exportarTipoHabitacion(cec.conexionSQL):

    def __init__(self,*args,**kwargs):
        super().__init__(*args,**kwargs)
        self.exportarThabitacion()

    def exportarThabitacion(self):
        conn_pg = psycopg2.connect(database=self.database, user=self.user, password=self.password, host=self.host)
        cursor_pg = conn_pg.cursor()

    
        sql_query = "SELECT * FROM tipo_habitacion"
        cursor_pg.execute(sql_query)
        rows = cursor_pg.fetchall()

 
        root = ET.Element("data")


        for row in rows:
            record = ET.SubElement(root, "record")
            for index, column_value in enumerate(row):
                field_name = cursor_pg.description[index][0]
                field = ET.SubElement(record, field_name)
                field.text = str(column_value)

        tree = ET.ElementTree(root)
        tree.write("thabitacionExportar.xml")


        conn_pg.close()
    

