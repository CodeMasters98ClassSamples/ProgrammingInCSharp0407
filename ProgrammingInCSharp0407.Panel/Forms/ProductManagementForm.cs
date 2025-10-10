using ProgrammingInCSharp0407.Panel.Models;

namespace ProgrammingInCSharp0407.Panel.Forms;

public partial class ProductManagementForm : Form
{
    List<Product> products;
    public ProductManagementForm()
    {
        InitializeComponent();


        //intial values
        products = new List<Product>();
        products.Add(new Product() { Name = "کیمیاگر", Code = "001", IsSellable = true, Price = 0 });
        products.Add(new Product() { Name = "کیمیاگر2", Code = "002", IsSellable = true, Price = 0 });

        FillDataGrid(products);
    }

    private void addProductButton_Click(object sender, EventArgs e)
    {
        Product product = new Product(name: nameTextBox.Text, code: codeTextBox.Text);
        products.Add(product);
        FillDataGrid(products);
    }

    private void FillDataGrid(List<Product> myProducts)
    {
        productDataGridView.DataSource = null;
        productDataGridView.DataSource = myProducts;
        productDataGridView.Refresh();
    }

}
