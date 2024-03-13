from odoo import models, fields

class TipoHabitacion(models.Model):
    _name = 'tipo.habitacion'

    tipoID = fields.Integer(string='ID de Tipo', required=True)
    descripcion = fields.Char(string='Descripción', required=True, size=20)
