#!/usr/bin/python3
from xmlrpc import client
import xml.etree.ElementTree as ET
from datetime import datetime
import os,sys
import conectionClass as cc
# Conectar 



class conectarReservas(cc.ConexionOdoo):


    
    def __init__(self,*args,**kwargs):
        super().__init__(*args,**kwargs)
        self.conectarReservas()
        #print(self.dbname)
        
        
    def conectarReservas(self):

        pathRoot = os.path.abspath(__file__)
        pathName = os.path.basename(pathRoot)
        pathDirectory = pathRoot.split(pathName)[0]
        reservas = pathDirectory + "Reservas.XML"
        if os.path.exists(reservas):
            tree = ET.parse(reservas)     
            root = tree.getroot()
            
        else:
            print("WARNING: La ruta no existe")


        for elemento in root.findall('.//Elementos'): 
            
            for reserva in elemento.findall('.//anyType[@{http://www.w3.org/2001/XMLSchema-instance}type="Reservas"]', namespaces={'xsi': 'http://www.w3.org/2001/XMLSchema-instance'}):

                reservaID = reserva.find('reservaID').text
                numeroHabitacion = reserva.find('numeroHabitacion').text
                temporadaID = reserva.find('temporadaID').text
                pensionID = reserva.find('pensionID').text
                NIF = reserva.find('NIF').text
                firmado = reserva.find('firmado').text
                fechaEntrada = reserva.find('fechaEntrada').text
                fechaSalida = reserva.find('fechaSalida').text


                reservaID = int(reservaID)
                firmado = int(firmado)
                fechaEntrada = datetime.strptime(fechaEntrada, "%Y-%m-%dT%H:%M:%S").strftime("%Y-%m-%d %H:%M:%S")
                fechaSalida = datetime.strptime(fechaSalida, "%Y-%m-%dT%H:%M:%S").strftime("%Y-%m-%d %H:%M:%S")
                numeroHabitacion = int(numeroHabitacion)
                temporadaID = int(temporadaID)
                pensionID = int(pensionID)

                reservaExistente = self.models.execute_kw(self.dbname, self.uid, self.pwd, 'reserva', 'search', [[['reservaID', '=', reservaID]]])
                
                if reservaExistente:
                    # Actualizar
                    self.models.execute_kw(self.dbname, self.uid, self.pwd, 'reserva', 'write', [reservaID, {"numeroHabitacion":numeroHabitacion,"temporadaID":temporadaID,"pensionID":pensionID,"NIF":NIF,
                    "firmado":firmado,"fechaEntrada":fechaEntrada,"fechaSalida":fechaSalida}])
                    
                    
                else:
                    # Crear
                    new_id = self.models.execute_kw(self.dbname, self.uid, self.pwd, 'reserva', 'create', [{'reservaID': reservaID,"numeroHabitacion":numeroHabitacion,"temporadaID":temporadaID,"pensionID":pensionID,"NIF":NIF,
                    "firmado":firmado,"fechaEntrada":fechaEntrada,"fechaSalida":fechaSalida}])
                    

