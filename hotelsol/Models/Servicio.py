from odoo import models, fields

class Servicio(models.Model):
    _name = 'servicio'

    idServicio = fields.Integer(string='ID de Servicio', required=True)
    precioServicio = fields.Float(string='Precio de Servicio', required=True)
    descripcion = fields.Char(string='Descripción', required=True, size=1000)
    tipoServicioID = fields.Integer(string='ID de Tipo de Servicio')
    precioAlta = fields.Float(string='Precio Alta', required=True)
    precioBaja = fields.Float(string='Precio Baja', required=True)
    precioMedia = fields.Float(string='Precio Media', required=True)
    permisoAlta = fields.Integer(string='Permiso Alta')
    permisoMedia = fields.Integer(string='Permiso Media')
    permisoBaja = fields.Integer(string='Permiso Baja')
    descVIP = fields.Float(string='Descuento VIP', required=True)
