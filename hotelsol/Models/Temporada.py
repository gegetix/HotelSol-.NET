from odoo import models,fields

class Temporada(models.Model):

    _name = "temporada"
    temporadaID = fields.Char(string='Temporada ID', required=True)
    descripcion = fields.Char(string='Descripción', required=True)
    
    