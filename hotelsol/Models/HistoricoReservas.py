from odoo import models, fields

class HistoricoReservas(models.Model):
    _name = 'historico.reservas'

    reservaID = fields.Integer(string='Reserva ID', required=True)
    habitacion = fields.Integer(string='Habitación', required=True)
    nombre = fields.Char(string='Nombre')
    entrada = fields.Date(string='Entrada', required=True)
    salida = fields.Date(string='Salida', required=True)
    estado = fields.Char(string='Estado')
    idIncidencia = fields.Integer(string='ID de Incidencia')
