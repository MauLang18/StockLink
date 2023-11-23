﻿namespace StockLink.Domain.Entities
{
    public class Articulo
    {
        public string? ARTICULO { get; set; }
        public string? PLANTILLA_SERIE { get; set; }
        public string? DESCRIPCION { get; set; }
        public string? CLASIFICACION_1 { get; set; }
        public string? CLASIFICACION_2 { get; set; }
        public string? CLASIFICACION_3 { get; set; }
        public string? CLASIFICACION_4 { get; set; }
        public string? CLASIFICACION_5 { get; set; }
        public string? CLASIFICACION_6 { get; set; }
        public string? FACTOR_CONVER_1 { get; set; }
        public string? FACTOR_CONVER_2 { get; set; }
        public string? FACTOR_CONVER_3 { get; set; }
        public string? FACTOR_CONVER_4 { get; set; }
        public string? FACTOR_CONVER_5 { get; set; }
        public string? FACTOR_CONVER_6 { get; set; }
        public string? TIPO { get; set; }
        public string? OTRIGEN_CORP { get; set; }
        public decimal? PESO_NETO { get; set; }
        public decimal? PESO_BRUTO { get; set; }
        public decimal? VOLUMEN { get; set; }
        public int? BULTOS { get; set; }
        public string? ARTICULO_CUENTA { get; set; }
        public string? IMPUESTO { get; set; }
        public decimal? FACTOR_EMPAQUE { get; set; }
        public decimal? FACTOR_VENTA { get; set; }
        public decimal? EXISTENCIA_MINIMA { get; set; }
        public decimal? EXISTENCIA_MAXIMA { get; set; }
        public decimal? PUNTO_DE_REORDEN { get; set; }
        public string? COSTO_FISCAL { get; set; }
        public string? COSTO_COMPORATIVO { get; set; }
        public decimal? COSTO_PROM_LOC { get; set; }
        public decimal? COSTO_PROM_DOL { get; set; }
        public decimal? COSTO_STD_LOC { get; set; }
        public decimal? COSTO_STD_DOL { get; set; }
        public decimal? COSTO_ULT_LOC { get; set; }
        public decimal? COSTO_ULT_DOL { get; set; }
        public decimal? PRECIO_BASE_LOCAL { get; set; }
        public decimal? PRECIO_BASE_DOLAR { get; set; }
        public DateTime? ULTIMA_SALIDA { get; set; }
        public DateTime? ULTIMO_MOVIMIENTO { get; set; }
        public DateTime? ULTIMO_INGRESO { get; set; }
        public DateTime? ULTIMO_INVENTARIO { get; set; }
        public string? CLASE_ABC { get; set; }
        public string? FRECUENCIA_CONTEO { get; set; }
        public string? CODIGO_BARRAS_VENT { get; set; }
        public string? CODIGO_BARRAS_INVT { get; set; }
        public string? ACTIVO { get; set; }
        public string? USA_LOTES { get; set; }
        public string? OBLIGA_CUARENTENA { get; set; }
        public int? MIN_VIDA_COMPRA { get; set; }
        public int? MIN_VIDA_CONSUMO { get; set; }
        public int? MIN_VIDA_VENTA { get; set; }
        public int? MIN_VIDA_PROM { get; set; }
        public int? DIAS_CUARENTENA { get; set; }
        public string? PROVEEDOR { get; set; }
        public string? ARTICULO_DEL_PROV { get; set; }
        public decimal? ORDEN_MINIMA { get; set; }
        public int? PLAZO_REABAST { get; set; }
        public decimal? LOTE_MULTIPLO { get; set; }
        public string? NOTAS { get; set; }
        public string? UTILIZADO_MANUFACT { get; set; }
        public string? USUARIO_CREACION { get; set; }
        public DateTime? FCH_HORA_CREACION { get; set; }
        public string? USUARIO_ULT_MODIF { get; set; }
        public DateTime? FCH_HORA_ULT_MODIF { get; set; }
        public string? USA_NUMEROS_SERIE { get; set; }
        public string? MODALIDAD_INV_FIS { get; set; }
        public string? TIPO_COD_BARRA_DET { get; set; }
        public string? TIPO_COD_BARRA_ALM { get; set; }
        public string? USA_REGLAS_LOCALES { get; set; }
        public string? UNIDAD_ALMACEN { get; set; }
        public string? UNIDAD_EMPAQUE { get; set; }
        public string? UNIDAD_VENTA { get; set; }
        public string? PERECEDERO { get; set; }
        public string? GTIN { get; set; }
        public string? MANUFACTURADOR { get; set; }
        public string? CODIGO_RETENCION { get; set; }
        public string? RETENCION_VENTA { get; set; }
        public string? RETENCION_COMPRA { get; set; }
        public string? MODELO_RETENCION { get; set; }
        public string? ESTILO { get; set; }
        public string? TALLA { get; set; }
        public string? COLOR { get; set; }
        public string? TIPO_COSTO { get; set; }
        public string? ARTICULO_ENVASE { get; set; }
        public string? ES_ENVASE { get; set; }
        public string? USA_CONTROL_ENVASE { get; set; }
        public decimal? COSTO_PROM_COMPARATIVO_LOC { get; set; }
        public decimal? COSTO_PROM_COMPARATIVO_DOLAR { get; set; }
        public decimal? COSTO_PROM_ULTIMO_LOC { get; set; }
        public decimal? COSTO_PROM_ULTIMO_DOL { get; set; }
        public byte? NoteExistsFlag { get; set; }
        public DateTime? RecordDate { get; set; }
        public Guid? RowPointer { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? UTILIZADO_EN_CONTRATOS { get; set; }
        public string? VALIDA_CANT_FASE_PY { get; set; }
        public string? OBLIGA_INCLUIR_FASE_PY { get; set; }
        public string? ES_IMPUESTO { get; set; }
        public string? U_CLAVE_UNIDAD { get; set; }
        public string? U_CLAVE_PROD_SERV { get; set; }
        public string? U_CLAVE_PS_PUB { get; set; }
        public string? TIPO_DOC_IVA { get; set; }
        public string? NIT { get; set; }
        public string? CANASTA_BASICA { get; set; }
        public string? ES_OTRO_CARGO { get; set; }
        public string? SERVICIO_MEDICO { get; set; }
        public string? item_hacienda { get; set; }
        public string? CODIGO_HACIENDA { get; set; }
        public string? ITEM_HACIENDA_COMPRA { get; set; }
        public string? TIENDA { get; set; }
        public string? SUGIERE_MIN { get; set; }
        public string? TIPO_EXISTENCIA { get; set; }
        public string? CATALOGO_EXISTENCIA { get; set; }
        public string? TIPO_DETRACCION_VENTA { get; set; }
        public string? CODIGO_DETRACCION_VENTA { get; set; }
        public string? TIPO_DETRACCION_COMPRA { get; set; }
        public string? CODIGO_DETRACCION_COMPRA { get; set; }
        public string? CALC_PERCEP { get; set; }
        public decimal? PORC_PERCEP { get; set; }
        public string? U_ABC_VENTAS { get; set; }
        public string? U_ABC_POPULARIDAD { get; set; }
        public string? U_ABC_DEMANDA { get; set; }
        public string? U_ABC_TRIPLE { get; set; }
        public decimal? U_ABC_PESO { get; set; }
        public string? TIPO_VENTA { get; set; }
    }
}