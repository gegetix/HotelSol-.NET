import importReservasXML as ir
import importClientesXML as ic
import importRegimenXML as irp
import importHabitacionXML as ih
import importarServicioXML as ise
import importarTemporadaXML as it
import importarTHabitacionXML as ith
import sys


def importarOdooXML(arg=None):

    if arg == "Reserva":
        inst = ir.conectarReservas()
        
    elif arg == "Clientes":
        instc = ic.conectarClientes()
        
    elif arg == "RegimenPension":
        insta = irp.conectarRegimenPension()
        
    elif arg == "Habitacion":
        ins = ih.conectarHabitacion()
        
    elif arg == "Servicio":
        ins1 = ise.conectarServicio()
        
    elif arg == "Temporada":
        ite = it.conectarTemporada()
        
    elif arg == "TipoHabitacion":
        
        itha = ith.conectarTHabitacion()
        

arg = sys.argv[1]

if arg != None:
    importarOdooXML(arg = arg)
else:
    print("WARNING: la ruta no existe")