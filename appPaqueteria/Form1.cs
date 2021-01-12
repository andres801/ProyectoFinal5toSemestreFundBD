using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appPaqueteria
{
    public partial class Form1 : Form
    {
        string consulta = "";
        DataSet ds = new DataSet();
        string tablita;
        string serverBD;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (Datos.server == "SQL Server elegido")
            {
                tablita = this.cboTablas.GetItemText(this.cboTablas.SelectedItem);
                consulta = "SELECT * FROM " + tablita + " where estatus = 1";
                Datos.AgregarDataTable(ds, consulta, "Paqueteria", dataGridView1);
                //dataGridView1.DataSource = ds.Tables["Paqueteria"];
            }
            if (Datos.server == "Maria DB elegido")
            {
                tablita = this.cboTablas.GetItemText(this.cboTablas.SelectedItem);
                consulta = "SELECT * FROM " + tablita + ";";
                Datos.AgregarDataTable(ds, consulta, "Paqueteria", dataGridView1);
            }
            if (Datos.server == "Postgre SQL elegido")
            {
                tablita = this.cboTablas.GetItemText(this.cboTablas.SelectedItem);
                consulta = "SELECT * FROM " + tablita + ";";
                Datos.AgregarDataTable(ds, consulta, "Paqueteria", dataGridView1);
            }
            
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            tablita = this.cboTablas.GetItemText(this.cboTablas.SelectedItem);
            switch (tablita)
            {
                case "Sucursal":
                    consulta = "INSERT INTO " + tablita + " (codigoSucursal, direccion, telefono, idCiudad, idEstado, idPais)  VALUES " + "('" + txtCodigo.Text + "','" + txtDireccionSucursal.Text + "','" + txtTelefonoSucursal.Text + "'," + numUDidCiudadSucursal.Value + "," + numUDidEstadoSucursal.Value + "," + numUDidPaisSucursal.Value + ");";
                    break;
                case "Ciudad":
                    consulta = "INSERT INTO " + tablita + " (codigoCiudad, nombre)  VALUES " + "('" + txtCodigo.Text + "','" + txtNombreCEP.Text + "');";
                    break;
                case "Estado":
                    consulta = "INSERT INTO " + tablita + " (codigoEstado, nombre)  VALUES " + "('" + txtCodigo.Text + "','" + txtNombreCEP.Text + "');";
                    break;
                case "Pais":
                    consulta = "INSERT INTO " + tablita + " (codigoPais, nombre)  VALUES " + "('" + txtCodigo.Text + "','" + txtNombreCEP.Text + "');";
                    break;
                case "Envio":
                    consulta = "INSERT INTO " + tablita + " (codigoEnvio, referencia, idSucursal, idRemitente, idReceptor, idOrigen, idDestino, idVehiculo5taRueda, idVehiculoRegular, idEnvioRegular, idEnvioComida, idEnvioInstrumentos, idEnvioFarmacos, idEnvioOrganicos, idEnvioVidrio, idEnvioBasura, idEnvioRPBI, idTransferencia, idPagoContado, idPagoCredito, idPagoDebito, idDevolucion, idPagoConMP, idDeposito) VALUES " + "('" + txtCodigo.Text + "','" + txtReferenciaEnvio.Text + "'," + numUDidSucursalEnvio.Value + "," + numUDidRemitenteEnvio.Value + "," + numUDidReceptorEnvio.Value + "," + numUDidOrigenEnvio.Value + "," + numUDidDestinoEnvio.Value + "," + numUDidVe5taRuedaEnvio.Value + "," + numUDidVeRegularEnvio.Value + "," + numUDidEnvioRegularEnvio.Value + "," + numUDidEnvioComidaEnvio.Value + "," + numUDidEnvioInstrumentosEnvio.Value + "," + numUDidEnvioFarmacosEnvio.Value + "," + numUDidEnvioOrganicosEnvio.Value + "," + numUDidEnvioVidrioEnvio.Value + "," + numUDidEnvioBasuraEnvio.Value + "," + numUDidEnvioRPBIEnvio.Value + "," + numUDidTransferenciaEnvio.Value + "," + numUDidPagoContadoEnvio.Value + "," + numUDidPagoCreditoEnvio.Value + "," + numUDidPagoDebitoEnvio.Value + "," + numUDidDevolucionEnvio.Value + "," + numUDidPagoConMPEnvio.Value + "," + numUDidDepositoEnvio.Value + ");";
                    break;
                case "EnvioRegular":
                    consulta = "INSERT INTO " + tablita + " (codigoEnvioRegular, referencia)  VALUES " + "('" + txtCodigo.Text + "','" + txtReferenciaTipoEnvio.Text + "');";
                    break;
                case "EnvioComida":
                    consulta = "INSERT INTO " + tablita + " (codigoEnvioComida, referencia)  VALUES " + "('" + txtCodigo.Text + "','" + txtReferenciaTipoEnvio.Text + "');";
                    break;
                case "EnvioInstrumentos":
                    consulta = "INSERT INTO " + tablita + " (codigoEnvioInstrumentos, referencia)  VALUES " + "('" + txtCodigo.Text + "','" + txtReferenciaTipoEnvio.Text + "');";
                    break;
                case "EnvioFarmacos":
                    consulta = "INSERT INTO " + tablita + " (codigoEnvioFarmacos, referencia)  VALUES " + "('" + txtCodigo.Text + "','" + txtReferenciaTipoEnvio.Text + "');";
                    break;
                case "EnvioOrganicos":
                    consulta = "INSERT INTO " + tablita + " (codigoEnvioOrganicos, referencia)  VALUES " + "('" + txtCodigo.Text + "','" + txtReferenciaTipoEnvio.Text + "');";
                    break;
                case "EnvioVidrio":
                    consulta = "INSERT INTO " + tablita + " (codigoEnvioVidrio, referencia)  VALUES " + "('" + txtCodigo.Text + "','" + txtReferenciaTipoEnvio.Text + "');";
                    break;
                case "EnvioBasura":
                    consulta = "INSERT INTO " + tablita + " (codigoEnvioBasura, referencia)  VALUES " + "('" + txtCodigo.Text + "','" + txtReferenciaTipoEnvio.Text + "');";
                    break;
                case "EnvioRPBI":
                    consulta = "INSERT INTO " + tablita + " (codigoEnvioRPBI, referencia)  VALUES " + "('" + txtCodigo.Text + "','" + txtReferenciaTipoEnvio.Text + "');";
                    break;

                case "Origen":
                    consulta = "INSERT INTO " + tablita + " (codigoOrigen, ciudad, direccion)  VALUES " + "('" + txtCodigo.Text + "','" + txtCiudadOD.Text + "','" + txtDireccionOD.Text + "');";
                    break;
                case "Destino":
                    consulta = "INSERT INTO " + tablita + " (codigoDestino, ciudad, direccion)  VALUES " + "('" + txtCodigo.Text + "','" + txtCiudadOD.Text + "','" + txtDireccionOD.Text + "');";
                    break;
                case "Remitente":
                    consulta = "INSERT INTO " + tablita + " (codigoRemitente, nombre, ciudad, direccion)  VALUES " + "('" + txtCodigo.Text + "','" + txtNombreRR.Text + "','" + txtCiudadRR.Text + "','" + txtDireccionRR.Text + "');";
                    break;
                case "Receptor":
                    consulta = "INSERT INTO " + tablita + " (codigoReceptor, nombre, ciudad, direccion)  VALUES " + "('" + txtCodigo.Text + "','" + txtNombreRR.Text + "','" + txtCiudadRR.Text + "','" + txtDireccionRR.Text + "');";
                    break;
                case "Vehiculo5taRueda":
                    consulta = "INSERT INTO " + tablita + " (codigoVehiculo5taRueda, placa)  VALUES " + "('" + txtCodigo.Text + "','" + txtPlaca.Text + "');";
                    break;
                case "VehiculoRegular":
                    consulta = "INSERT INTO " + tablita + " (codigoVehiculoRegular, placa)  VALUES " + "('" + txtCodigo.Text + "','" + txtPlaca.Text + "');";
                    break;

                case "Transferencia":
                    consulta = "INSERT INTO " + tablita + " (codigoTransferencia, monto)  VALUES " + "('" + txtCodigo.Text + "','" + txtMonto.Text + "');";
                    break;
                case "PagoContado":
                    consulta = "INSERT INTO " + tablita + " (codigoPagoContado, monto)  VALUES " + "('" + txtCodigo.Text + "','" + txtMonto.Text + "');";
                    break;
                case "PagoCredito":
                    consulta = "INSERT INTO " + tablita + " (codigoPagoCredito, monto)  VALUES " + "('" + txtCodigo.Text + "','" + txtMonto.Text + "');";
                    break;
                case "PagoDebito":
                    consulta = "INSERT INTO " + tablita + " (codigoPagoDebito, monto)  VALUES " + "('" + txtCodigo.Text + "','" + txtMonto.Text + "');";
                    break;
                case "Devolucion":
                    consulta = "INSERT INTO " + tablita + " (codigoDevolucion, monto)  VALUES " + "('" + txtCodigo.Text + "','" + txtMonto.Text + "');";
                    break;
                case "PagoConMP":
                    consulta = "INSERT INTO " + tablita + " (codigoPagoConMP, monto)  VALUES " + "('" + txtCodigo.Text + "','" + txtMonto.Text + "');";
                    break;
                case "Deposito":
                    consulta = "INSERT INTO " + tablita + " (codigoDeposito, monto)  VALUES " + "('" + txtCodigo.Text + "','" + txtMonto.Text + "');";
                    break;

                case "ProveedorPublicidad":
                    consulta = "INSERT INTO " + tablita + " (codigoProveedorPublicidad, nombre, idSucursal)  VALUES " + "('" + txtCodigo.Text + "','" + txtNombrePE.Text + "'," + numUDidSucursalPE.Value + ");";
                    break;
                case "ProveedorConsumiblesImpresion":
                    consulta = "INSERT INTO " + tablita + " (codigoProveedorConsumiblesImpresion, nombre, idSucursal)  VALUES " + "('" + txtCodigo.Text + "','" + txtNombrePE.Text + "'," + numUDidSucursalPE.Value + ");";
                    break;
                case "ProveedorPapeleria":
                    consulta = "INSERT INTO " + tablita + " (codigoProveedorPapeleria, nombre, idSucursal)  VALUES " + "('" + txtCodigo.Text + "','" + txtNombrePE.Text + "'," + numUDidSucursalPE.Value + ");";
                    break;
                case "ProveedorInternet":
                    consulta = "INSERT INTO " + tablita + " (codigoProveedorInternet, nombre, idSucursal)  VALUES " + "('" + txtCodigo.Text + "','" + txtNombrePE.Text + "'," + numUDidSucursalPE.Value + ");";
                    break;
                case "ProveedorComputo":
                    consulta = "INSERT INTO " + tablita + " (codigoProveedorComputo, nombre, idSucursal)  VALUES " + "('" + txtCodigo.Text + "','" + txtNombrePE.Text + "'," + numUDidSucursalPE.Value + ");";
                    break;
                case "ProveedorGasolina":
                    consulta = "INSERT INTO " + tablita + " (codigoProveedorGasolina, nombre, idSucursal)  VALUES " + "('" + txtCodigo.Text + "','" + txtNombrePE.Text + "'," + numUDidSucursalPE.Value + ");";
                    break;
                case "ProveedorAC":
                    consulta = "INSERT INTO " + tablita + " (codigoProveedorAC, nombre, idSucursal)  VALUES " + "('" + txtCodigo.Text + "','" + txtNombrePE.Text + "'," + numUDidSucursalPE.Value + ");";
                    break;
                case "ProveedorElectricidad":
                    consulta = "INSERT INTO " + tablita + " (codigoProveedorElectricidad, nombre, idSucursal)  VALUES " + "('" + txtCodigo.Text + "','" + txtNombrePE.Text + "'," + numUDidSucursalPE.Value + ");";
                    break;
                case "ProveedorEmpaques":
                    consulta = "INSERT INTO " + tablita + " (codigoProveedorEmpaques, nombre, idSucursal)  VALUES " + "('" + txtCodigo.Text + "','" + txtNombrePE.Text + "'," + numUDidSucursalPE.Value + ");";
                    break;

                case "Guardia":
                    consulta = "INSERT INTO " + tablita + " (codigoGuardia, nombre, idSucursal)  VALUES " + "('" + txtCodigo.Text + "','" + txtNombrePE.Text + "'," + numUDidSucursalPE.Value + ");";
                    break;
                case "Vocero":
                    consulta = "INSERT INTO " + tablita + " (codigoVocero, nombre, idSucursal)  VALUES " + "('" + txtCodigo.Text + "','" + txtNombrePE.Text + "'," + numUDidSucursalPE.Value + ");";
                    break;
                case "Mercadologo":
                    consulta = "INSERT INTO " + tablita + " (codigoMercadologo, nombre, idSucursal)  VALUES " + "('" + txtCodigo.Text + "','" + txtNombrePE.Text + "'," + numUDidSucursalPE.Value + ");";
                    break;
                case "Medico":
                    consulta = "INSERT INTO " + tablita + " (codigoMedico, nombre, idSucursal)  VALUES " + "('" + txtCodigo.Text + "','" + txtNombrePE.Text + "'," + numUDidSucursalPE.Value + ");";
                    break;
                case "Enfermero":
                    consulta = "INSERT INTO " + tablita + " (codigoEnfermero, nombre, idSucursal)  VALUES " + "('" + txtCodigo.Text + "','" + txtNombrePE.Text + "'," + numUDidSucursalPE.Value + ");";
                    break;
                case "RepreServClienteTelefono":
                    consulta = "INSERT INTO " + tablita + " (codigoRepreServClienteTelefono, nombre, idSucursal)  VALUES " + "('" + txtCodigo.Text + "','" + txtNombrePE.Text + "'," + numUDidSucursalPE.Value + ");";
                    break;
                case "RepreServClienteInternet":
                    consulta = "INSERT INTO " + tablita + " (codigoRepreServClienteInternet, nombre, idSucursal)  VALUES " + "('" + txtCodigo.Text + "','" + txtNombrePE.Text + "'," + numUDidSucursalPE.Value + ");";
                    break;
                case "JefeArea":
                    consulta = "INSERT INTO " + tablita + " (codigoJefeArea, nombre, idSucursal)  VALUES " + "('" + txtCodigo.Text + "','" + txtNombrePE.Text + "'," + numUDidSucursalPE.Value + ");";
                    break;
                case "Directivo":
                    consulta = "INSERT INTO " + tablita + " (codigoDirectivo, nombre, idSucursal)  VALUES " + "('" + txtCodigo.Text + "','" + txtNombrePE.Text + "'," + numUDidSucursalPE.Value + ");";
                    break;
                case "Secretario":
                    consulta = "INSERT INTO " + tablita + " (codigoSecretario, nombre, idSucursal)  VALUES " + "('" + txtCodigo.Text + "','" + txtNombrePE.Text + "'," + numUDidSucursalPE.Value + ");";
                    break;
                case "Intendente":
                    consulta = "INSERT INTO " + tablita + " (codigoIntendente, nombre, idSucursal)  VALUES " + "('" + txtCodigo.Text + "','" + txtNombrePE.Text + "'," + numUDidSucursalPE.Value + ");";
                    break;
                case "Cocinero":
                    consulta = "INSERT INTO " + tablita + " (codigoCocinero, nombre, idSucursal)  VALUES " + "('" + txtCodigo.Text + "','" + txtNombrePE.Text + "'," + numUDidSucursalPE.Value + ");";
                    break;
                case "Conductor":
                    consulta = "INSERT INTO " + tablita + " (codigoConductor, nombre, idSucursal)  VALUES " + "('" + txtCodigo.Text + "','" + txtNombrePE.Text + "'," + numUDidSucursalPE.Value + ");";
                    break;
                case "Repartidor":
                    consulta = "INSERT INTO " + tablita + " (codigoRepartidor, nombre, idSucursal)  VALUES " + "('" + txtCodigo.Text + "','" + txtNombrePE.Text + "'," + numUDidSucursalPE.Value + ");";
                    break;
                case "Clasificador":
                    consulta = "INSERT INTO " + tablita + " (codigoClasificador, nombre, idSucursal)  VALUES " + "('" + txtCodigo.Text + "','" + txtNombrePE.Text + "'," + numUDidSucursalPE.Value + ");";
                    break;
                case "Empaquetador":
                    consulta = "INSERT INTO " + tablita + " (codigoEmpaquetador, nombre, idSucursal)  VALUES " + "('" + txtCodigo.Text + "','" + txtNombrePE.Text + "'," + numUDidSucursalPE.Value + ");";
                    break;
                case "Contador":
                    consulta = "INSERT INTO " + tablita + " (codigoContador, nombre, idSucursal)  VALUES " + "('" + txtCodigo.Text + "','" + txtNombrePE.Text + "'," + numUDidSucursalPE.Value + ");";
                    break;




                default:
                    break;
            }
            //consulta = "INSERT INTO Compañia(NumeroCompañia, actividad, estatus) VALUES('c#', 'c sharp', 1);";
            int r = Datos.EjecutarConsulta(consulta);
        }

        private void cboTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            tablita = this.cboTablas.GetItemText(this.cboTablas.SelectedItem);
            switch (tablita)
            {
                case "Sucursal":
                    consulta = "INSERT INTO " + tablita + "(codigoSucursal, direccion, telefono, idCiudad, idEstado, idPais) VALUES" + "(" + txtCodigo.Text + txtDireccionSucursal.Text + txtTelefonoSucursal.Text + numUDidCiudadSucursal.Value + numUDidEstadoSucursal.Value + numUDidPaisSucursal.Value + ");";
                    break;

                default:
                    break;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                tablita = this.cboTablas.GetItemText(this.cboTablas.SelectedItem);
                consulta = "UPDATE " + tablita + " SET " + txtCampoAModificar.Text + " = '" + txtTextoModificado.Text + "'" + " where " + "id" + tablita + " = " + numUDidDelRegistroModificar.Value;

                //consulta = "UPDATE Compañia SET actividad='HOLA'where idCompañia=6";
                int r = Datos.EjecutarConsulta(consulta);
            }
            catch (Exception)
            {
                MessageBox.Show("Conflicto de integridad, actualice el registro al que se enlaza primero");
                Datos.conexionPOSTGRE.Close();
                //throw;
            }
            

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            txtCiudadOD.Text = "1";
            txtCiudadRR.Text = "1";
            txtCodigo.Text = "1";
            txtDireccionOD.Text = "1";
            txtDireccionRR.Text = "1";
            txtDireccionSucursal.Text = "1";
            txtMonto.Text = "1";
            txtNombreCEP.Text = "1";
            txtNombrePE.Text = "1";
            txtNombreRR.Text = "1";
            txtPlaca.Text = "1";
            txtReferenciaEnvio.Text = "1";
            txtReferenciaTipoEnvio.Text = "1";
            txtTelefonoSucursal.Text = "1";
            txtTextoModificado.Text = "cambiado";
            numUDidCiudadSucursal.Value = 1;
            numUDidDepositoEnvio.Value = 1;
            numUDidDestinoEnvio.Value = 1;
            numUDidDevolucionEnvio.Value = 1;
            numUDidEnvioBasuraEnvio.Value = 1;
            numUDidEnvioComidaEnvio.Value = 1;
            numUDidEnvioFarmacosEnvio.Value = 1;
            numUDidEnvioInstrumentosEnvio.Value = 1;
            numUDidEnvioOrganicosEnvio.Value = 1;
            numUDidEnvioRegularEnvio.Value = 1;
            numUDidEnvioRPBIEnvio.Value = 1;
            numUDidEnvioVidrioEnvio.Value = 1;
            numUDidEstadoSucursal.Value = 1;
            numUDidOrigenEnvio.Value = 1;
            numUDidPagoConMPEnvio.Value = 1;
            numUDidPagoContadoEnvio.Value = 1;
            numUDidPagoCreditoEnvio.Value = 1;
            numUDidPagoDebitoEnvio.Value = 1;
            numUDidPaisSucursal.Value = 1;
            numUDidReceptorEnvio.Value = 1;
            numUDidRemitenteEnvio.Value = 1;
            numUDidSucursalEnvio.Value = 1;
            numUDidSucursalPE.Value = 1;
            numUDidTransferenciaEnvio.Value = 1;
            numUDidVe5taRuedaEnvio.Value = 1;
            numUDidVeRegularEnvio.Value = 1;
            numUDidDelRegistroModificar.Value = 4;
            numUDidDelRegistroBorrar.Value = 5;
        }

        private void txtDelete_Click(object sender, EventArgs e)
        {
            try
            {
                tablita = this.cboTablas.GetItemText(this.cboTablas.SelectedItem);
                consulta = "DELETE FROM " + tablita + " where id" + tablita + " = " + numUDidDelRegistroBorrar.Value;

                //consulta = "DELETE FROM Compañia where idCompañia = 6";
                int r = Datos.EjecutarConsulta(consulta);
            }
            catch (Exception)
            {
                MessageBox.Show("Conflicto de integridad, borre el registro al que se enlaza primero");
                //throw;
                Datos.conexionPOSTGRE.Close();
            }
            
            

        }

        private void cboBD_SelectedIndexChanged(object sender, EventArgs e)
        {
            string conexionSolicitada;
            conexionSolicitada = this.cboBD.GetItemText(this.cboBD.SelectedItem);
            Datos.EstablecerConexion(conexionSolicitada);
            lblAviso.Text = "Usted se ha conectado con " + conexionSolicitada;
            cboTablas.Enabled = true;
            btnSelect.Enabled = true;
        }
    }
}
