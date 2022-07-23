<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label_Titulo = New System.Windows.Forms.Label()
        Me.Label_ID = New System.Windows.Forms.Label()
        Me.Label_NOME = New System.Windows.Forms.Label()
        Me.Label_NUMERO = New System.Windows.Forms.Label()
        Me.TextBox_ID = New System.Windows.Forms.TextBox()
        Me.TextBox_NOME = New System.Windows.Forms.TextBox()
        Me.TextBox_NUMERO = New System.Windows.Forms.TextBox()
        Me.Button_AdicionarDados = New System.Windows.Forms.Button()
        Me.Button_EditarDados = New System.Windows.Forms.Button()
        Me.Button_Excluir = New System.Windows.Forms.Button()
        Me.Button_Exibir = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button_Consultar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label_Titulo
        '
        Me.Label_Titulo.AutoSize = True
        Me.Label_Titulo.Location = New System.Drawing.Point(12, 9)
        Me.Label_Titulo.Name = "Label_Titulo"
        Me.Label_Titulo.Size = New System.Drawing.Size(41, 15)
        Me.Label_Titulo.TabIndex = 0
        Me.Label_Titulo.Text = "Label1"
        '
        'Label_ID
        '
        Me.Label_ID.AutoSize = True
        Me.Label_ID.Location = New System.Drawing.Point(12, 86)
        Me.Label_ID.Name = "Label_ID"
        Me.Label_ID.Size = New System.Drawing.Size(41, 15)
        Me.Label_ID.TabIndex = 1
        Me.Label_ID.Text = "Label2"
        '
        'Label_NOME
        '
        Me.Label_NOME.AutoSize = True
        Me.Label_NOME.Location = New System.Drawing.Point(12, 115)
        Me.Label_NOME.Name = "Label_NOME"
        Me.Label_NOME.Size = New System.Drawing.Size(41, 15)
        Me.Label_NOME.TabIndex = 2
        Me.Label_NOME.Text = "Label3"
        '
        'Label_NUMERO
        '
        Me.Label_NUMERO.AutoSize = True
        Me.Label_NUMERO.Location = New System.Drawing.Point(12, 144)
        Me.Label_NUMERO.Name = "Label_NUMERO"
        Me.Label_NUMERO.Size = New System.Drawing.Size(41, 15)
        Me.Label_NUMERO.TabIndex = 3
        Me.Label_NUMERO.Text = "Label4"
        '
        'TextBox_ID
        '
        Me.TextBox_ID.Location = New System.Drawing.Point(88, 83)
        Me.TextBox_ID.Name = "TextBox_ID"
        Me.TextBox_ID.Size = New System.Drawing.Size(100, 23)
        Me.TextBox_ID.TabIndex = 4
        '
        'TextBox_NOME
        '
        Me.TextBox_NOME.Location = New System.Drawing.Point(88, 112)
        Me.TextBox_NOME.Name = "TextBox_NOME"
        Me.TextBox_NOME.Size = New System.Drawing.Size(100, 23)
        Me.TextBox_NOME.TabIndex = 5
        '
        'TextBox_NUMERO
        '
        Me.TextBox_NUMERO.Location = New System.Drawing.Point(88, 141)
        Me.TextBox_NUMERO.Name = "TextBox_NUMERO"
        Me.TextBox_NUMERO.Size = New System.Drawing.Size(100, 23)
        Me.TextBox_NUMERO.TabIndex = 6
        '
        'Button_AdicionarDados
        '
        Me.Button_AdicionarDados.Location = New System.Drawing.Point(88, 170)
        Me.Button_AdicionarDados.Name = "Button_AdicionarDados"
        Me.Button_AdicionarDados.Size = New System.Drawing.Size(75, 23)
        Me.Button_AdicionarDados.TabIndex = 7
        Me.Button_AdicionarDados.Text = "Adicionar"
        Me.Button_AdicionarDados.UseVisualStyleBackColor = True
        '
        'Button_EditarDados
        '
        Me.Button_EditarDados.Location = New System.Drawing.Point(169, 170)
        Me.Button_EditarDados.Name = "Button_EditarDados"
        Me.Button_EditarDados.Size = New System.Drawing.Size(75, 23)
        Me.Button_EditarDados.TabIndex = 8
        Me.Button_EditarDados.Text = "Editar"
        Me.Button_EditarDados.UseVisualStyleBackColor = True
        '
        'Button_Excluir
        '
        Me.Button_Excluir.Location = New System.Drawing.Point(250, 170)
        Me.Button_Excluir.Name = "Button_Excluir"
        Me.Button_Excluir.Size = New System.Drawing.Size(75, 23)
        Me.Button_Excluir.TabIndex = 9
        Me.Button_Excluir.Text = "Excluir"
        Me.Button_Excluir.UseVisualStyleBackColor = True
        '
        'Button_Exibir
        '
        Me.Button_Exibir.Location = New System.Drawing.Point(331, 170)
        Me.Button_Exibir.Name = "Button_Exibir"
        Me.Button_Exibir.Size = New System.Drawing.Size(75, 23)
        Me.Button_Exibir.TabIndex = 10
        Me.Button_Exibir.Text = "Exibir"
        Me.Button_Exibir.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 215)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(599, 150)
        Me.DataGridView1.TabIndex = 11
        '
        'Button_Consultar
        '
        Me.Button_Consultar.Location = New System.Drawing.Point(412, 170)
        Me.Button_Consultar.Name = "Button_Consultar"
        Me.Button_Consultar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Consultar.TabIndex = 12
        Me.Button_Consultar.Text = "Consultar"
        Me.Button_Consultar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 382)
        Me.Controls.Add(Me.Button_Consultar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button_Exibir)
        Me.Controls.Add(Me.Button_Excluir)
        Me.Controls.Add(Me.Button_EditarDados)
        Me.Controls.Add(Me.Button_AdicionarDados)
        Me.Controls.Add(Me.TextBox_NUMERO)
        Me.Controls.Add(Me.TextBox_NOME)
        Me.Controls.Add(Me.TextBox_ID)
        Me.Controls.Add(Me.Label_NUMERO)
        Me.Controls.Add(Me.Label_NOME)
        Me.Controls.Add(Me.Label_ID)
        Me.Controls.Add(Me.Label_Titulo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_Titulo As Label
    Friend WithEvents Label_ID As Label
    Friend WithEvents Label_NOME As Label
    Friend WithEvents Label_NUMERO As Label
    Friend WithEvents TextBox_ID As TextBox
    Friend WithEvents TextBox_NOME As TextBox
    Friend WithEvents TextBox_NUMERO As TextBox
    Friend WithEvents Button_AdicionarDados As Button
    Friend WithEvents Button_EditarDados As Button
    Friend WithEvents Button_Excluir As Button
    Friend WithEvents Button_Exibir As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button_Consultar As Button
End Class
