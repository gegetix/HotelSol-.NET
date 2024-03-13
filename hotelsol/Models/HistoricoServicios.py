from odoo import models, fields

class HistoricoServicios(models.Model):
    _name = 'historico.servicios'

    idServicio = fields.Integer(string='ID de Servicio', required=True)
    reservaID = fields.Integer(string='Reserva ID', required=True)
    historicoID = fields.Integer(string='ID Histórico', required=True)
