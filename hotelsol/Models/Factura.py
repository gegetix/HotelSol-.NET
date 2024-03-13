from odoo import models, fields

class Factura(models.Model):
    _name = 'factura'

    numeroFactura = fields.Integer(string='Número de Factura', required=True)
    fechaFactura = fields.Date(string='Fecha de Factura', required=True)
    precioTotal = fields.Float(string='Precio Total', required=True)
    reservaID = fields.Char(string='Reserva', required=True)
    idCliente = fields.Char(string='ID del Cliente', required=True)
