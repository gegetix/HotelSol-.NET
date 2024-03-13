from odoo import models, fields

class Cliente(models.Model):
    _name = 'cliente'

    NIF = fields.Char(string='NIF', required=True)
    nombre = fields.Char(string='Nombre')
    apellidos = fields.Char(string='Apellidos')
    telefono = fields.Char(string='Teléfono')
    email = fields.Char(string='Email')
    VIP = fields.Integer(string='VIP', default=0)
    direccion = fields.Char(string='Dirección')
    ciudad = fields.Char(string='Ciudad')
    cp = fields.Integer(string='Código Postal')
    pais = fields.Char(string='País')
    fechaN = fields.Date(string='Fecha de Nacimiento')
    nombreCuenta = fields.Char(string='Nombre de la Cuenta')
    numeroCuenta = fields.Char(string='Número de Cuenta')
    fechaAlta = fields.Date(string='Fecha de Alta')
