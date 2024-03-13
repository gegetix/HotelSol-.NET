import ExportarClienteXML as ec
import ExportarFactura as ef
import ExportarHabitacion as eh
import ExportarRegimenPensionXML as erp
import ExportarReservaXML as er
import ExportarServicioXML as es
import ExportarTemporada as et
import ExportarTHabitacionXML as eth
import sys
def importarAHotel(arg = None):



    if arg == "Reservas":
       er.exportarReservaHotel()
    elif arg == "Clientes":
        ec.exportarClienteHotel()
    elif arg == "RegimenPension":
        erp.exportarRegimenHotel()
    elif arg == "Habitacion":
        eh.exportarHabitacion()
    elif arg == "Servicio":
        es.exportarServicio()     
    elif arg == "Temporada": 
        et.exportarTemporada()
    elif arg == "TipoHabitacion":
        eth.exportarTipoHabitacion()
        
        

arg = sys.argv[1]

if arg != None:
    importarAHotel(arg = arg)
else:
    print("WARNING: la ruta no existe")