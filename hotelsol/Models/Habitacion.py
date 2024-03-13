from odoo import models, fields

class Habitacion(models.Model):
    _name = 'habitacion'

    numeroHabitacion = fields.Integer(string='Número de Habitación', required=True)
    descripcion = fields.Char(string='Descripción', required=True, size=15)
    tipoID = fields.Integer(string='ID de Tipo', required=True)
    minNoches = fields.Integer(string='Número Mínimo de Noches')
    maxPersonas = fields.Integer(string='Número Máximo de Personas')
    precioAlta = fields.Float(string='Precio Alta', required=True)
    PrecioMedia = fields.Float(string='Precio Media', required=True)
    precioBaja = fields.Float(string='Precio Baja', required=True)
    fueraServicio = fields.Integer(string='Fuera de Servicio', default=False)
    