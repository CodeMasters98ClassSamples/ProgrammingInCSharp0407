using ProgrammingInCSharp0407.Panel.Models;
using ProgrammingInCSharp0407.Panel.Services;

namespace ProgrammingInCSharp0407.Panel.Forms;

public partial class ProductManagementForm : Form
{
    ProductService ProductService;
    public ProductManagementForm()
    {
        InitializeComponent();

        ProductService = new ProductService();
    }

    private void addProductButton_Click(object sender, EventArgs e)
    {
        Product product = new Product(name: nameTextBox.Text, code: codeTextBox.Text);
        ProductService.Add(product);
        FillDataGrid(ProductService.GetAll());  
    }

    private void FillDataGrid(List<Product> myProducts)
    {
        productDataGridView.DataSource = null;
        productDataGridView.DataSource = myProducts;
        productDataGridView.Refresh();
    }

}
