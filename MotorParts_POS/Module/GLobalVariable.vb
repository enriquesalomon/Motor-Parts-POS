Module GLobalVariable
    ' query = "SELECT SUM(tblitem.quantity) - SUM( tblsolditem.quantity) AS NEW_BAL, tblitem.barcode as barcode ,tblitem.itemname as itemname,tblitem.category as category FROM mppos_db.tblitem INNER JOIN mppos_db.tblsolditem ON tblitem.itemid=tblsolditem.itemid"

    Public myLogin As New Login
    Public myUser As New UserAccount
    Public myCategory As New Category
    Public myItem As New Item
    Public myStockin As New StockIn
    Public myStockAdjustment As New StockAdjustment
    Public myTransaction As New Transaction
    Public mySoldItem As New SalesMonitoring
    Public myStockInventory As New InventoryItem
    Public myTransactionMonitor As New TransactionMonitoring
    Public globalDefaultID As String
    Public path, globalClock As String
    Public saving, search As Boolean
    Public query, ORno, barcode As String
    Public Globaluserid, GlobalitemID, GlobalCatID As String
    Public globalstockNumber As Integer
    Public qtyInput As String
    Public qtyStock As String
    Public quantity As Integer
    Public SalePrice As Double
    Public idSolditem, idStockout As String
    Public onhanQty As Integer
    Public addQty As Integer
    Public triggerSecurityPass As String
    Public disInPrcent, discAmount, disc, netAmount As Double
    Public GlobalQty As Integer
    Public minusQty As Boolean
    Public userinfo, usertype As String
    Public ItemReportTemplate As String = Application.StartupPath & "\ITEMReport_01.xltx"
    Public SalesReportTemplate As String = Application.StartupPath & "\SALESReport_01.xltx"
    Public TransactionReportTemplate As String = Application.StartupPath & "\TRANSACTIONReport_01.xltx"
    Public ItemListTemplate As String = Application.StartupPath & "\ITEMLISTReport_01.xltx"
    Public StockInTemplate As String = Application.StartupPath & "\STOCKINReport_01.xltx"
    Public StockAdjustTemplate As String = Application.StartupPath & "\STOCKADJUSTReport_01.xltx"

End Module
