using Npgsql;
using System.Xml.Linq;

namespace GerenciadorDeUsuarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadUsers();
            CountUsers();
        }


        private Boolean UsersValidation()
        {
            User user = new User();
            if (!(string.IsNullOrEmpty(txtName.Text)))
            {
                return true;
            }
            else if (!(string.IsNullOrEmpty(txtEmail.Text)))
            {
                return true;
            }
            else if (user.CountName() != 0)
            {
                return true;
            }
            else if (Convert.ToInt32(txtAge.Text) >= 12 && Convert.ToInt32(txtAge.Text) <= 75)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void CleanForm()
        {
            txtId.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtTelephone.Clear();
            txtAge.Clear();
            txtDateOfBirth.Clear();
            txtName.Focus();
        }

        private void LoadUsers()
        {
            User user = new User();
            dgvUser.DataSource = user.GetAll();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            User user = new User();

            if (!UsersValidation())
            {
                try
                {
                    user.name = txtName.Text;
                    user.email = txtEmail.Text;
                    user.telephone = txtTelephone.Text;
                    user.age = Convert.ToInt16(txtAge.Text);
                    user.dateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);

                    bool response = user.add(user);

                    if (!response)
                    {
                        MessageBox.Show("Erro ao tentar gravar o produto");
                    }
                    else
                    {
                        CleanForm();
                        LoadUsers();
                    }

                }
                catch (Exception ex)
                {
                }
            }
            else
            {
                if (Convert.ToInt32(txtAge.Text) >= 12 && Convert.ToInt32(txtAge.Text) <= 75)
                {
                    MessageBox.Show("Idade inválida.");
                }
                else if (user.CountName() != 0)
                {
                    MessageBox.Show("Não podem haver dois usuários com mesmo nome.");
                }
                else
                {
                    MessageBox.Show("Os campos nome e email precisam ser preenchidos.");
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            CleanForm();
        }

        private void CountUsers()
        {
            User user = new User();
            lblCount.Text = user.Count().ToString();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("Confirma exclusão?", "Excluir",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {
                    User product = new User();
                    int id = Convert.ToInt32(txtId.Text);
                    bool response = product.Delete(id);

                    if (!response)
                        MessageBox.Show("Erro ao tentar excluir");
                    else
                    {
                        LoadUsers();
                    }

                }

            }
            catch (Exception)
            {

            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            User user = new User();

            if (!UsersValidation())
            {
                try
                {

                    DialogResult dialog = MessageBox.Show("Confirma alteração?", "Alteração",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {

                        user.id = Convert.ToInt32(txtId.Text);
                        user.name = txtName.Text;
                        user.email = txtEmail.Text;
                        user.telephone = txtTelephone.Text;
                        user.age = Convert.ToInt16(txtAge.Text);
                        user.dateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);

                        bool response = user.Update(user);

                        if (!response)
                            MessageBox.Show("Erro ao tentar alterar");
                        else
                        {
                            LoadUsers();
                        }

                    }
                }
                catch (Exception)
                {
                }
            }
            else
            {
                if (Convert.ToInt32(txtAge.Text) >= 12 && Convert.ToInt32(txtAge.Text) <= 75)
                {
                    MessageBox.Show("Idade inválida.");
                }
                else if (user.CountName() != 0)
                {
                    MessageBox.Show("Não podem haver dois usuários com mesmo nome.");
                }
                else
                {
                    MessageBox.Show("Os campos nome e email precisam ser preenchidos.");
                }
            }
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                User user = new User();

                int id = Convert.ToInt32(
                    dgvUser.Rows[dgvUser.CurrentRow.Index].Cells[0].Value);

                user = user.Get(id);

                txtId.Text = user.id.ToString();
                txtName.Text = user.name.ToString();
                txtEmail.Text = user.email.ToString();
                txtTelephone.Text = user.telephone.ToString();
                txtAge.Text = user.age.ToString();
                txtDateOfBirth.Text = user.dateOfBirth.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao tentar carregar os dados do produto");
            }
        }
    }
}