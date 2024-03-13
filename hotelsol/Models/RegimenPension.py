from odoo import models,fields

class RegimenPension(models.Model):

    _name = "regimen"
    pensionID = fields.Char(string='ID Pensión', required=True)
    descripcion = fields.Char(string='Descripción', required=True)
    precio = fields.Float(string='Precio', required=True)
    
    