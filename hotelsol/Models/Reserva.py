from odoo import models, fields

class Reserva(models.Model):
    _name = 'reserva'

    reservaID = fields.Integer(string='Reserva ID', required=True)
    firmado = fields.Integer(string='Firmado', default=False)
    fechaEntrada = fields.Datetime(string='Fecha de Entrada', required=True)
    fechaSalida = fields.Datetime(string='Fecha de Salida', required=True)
    NIF = fields.Char(string='NIF', required=True)
    numeroHabitacion = fields.Integer(string='Número de Habitación', required=True)
    temporadaID = fields.Integer(string='ID de Temporada', required=True)
    pensionID = fields.Integer(string='ID de Pensión', required=True)
