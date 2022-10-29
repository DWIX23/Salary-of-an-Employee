Public Class Form1
    Dim intRDB As Integer = 0
    Dim doubleCoop As Double = 0
    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 122) Or Asc(e.KeyChar) = 64 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 32 Or (Asc(e.KeyChar) <= 46 And Asc(e.KeyChar) >= 44) Or Asc(e.KeyChar) = 13 Then 'Or Asc(e.KeyChar) = 32 for space
            If Asc(e.KeyChar) = 13 Then
                txtPosition.Focus()
            End If
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtPosition_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPosition.KeyPress
        Dim strManager As String = "Manager"
        Dim strSupervisor As String = "Supervisor"
        Dim strTeamLeader As String = "Team Leader"
        Dim strDepartmentHead As String = "Department Head"
        Dim strSecurityGuard As String = "Security Guard"
        Dim strNull As String = " "
        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 122) Or Asc(e.KeyChar) = 64 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 45 Or Asc(e.KeyChar) = 13 Then 'Or Asc(e.KeyChar) = 32 for space
            If Asc(e.KeyChar) = 13 Then
                If String.Compare(strManager, txtPosition.Text, True) = 0 Then
                    intRDB = 1
                    If rdbA.Checked = True Then
                        txtGrossPay.Text = 25000
                    ElseIf rdbB.Checked = True Then
                        txtGrossPay.Text = 23000
                    End If

                ElseIf String.Compare(strSupervisor, txtPosition.Text, True) = 0 Then
                    intRDB = 2
                    If rdbA.Checked = True Then
                        txtGrossPay.Text = 2000
                    ElseIf rdbB.Checked = True Then
                        txtGrossPay.Text = 18000
                    End If

                ElseIf String.Compare(strTeamLeader, txtPosition.Text, True) = 0 Then
                    intRDB = 3
                    If rdbA.Checked = True Then
                        txtGrossPay.Text = 15000
                    ElseIf rdbB.Checked = True Then
                        txtGrossPay.Text = 13000
                    End If

                ElseIf String.Compare(strDepartmentHead, txtPosition.Text, True) = 0 Then
                    intRDB = 4
                    If rdbA.Checked = True Then
                        txtGrossPay.Text = 10000
                    ElseIf rdbB.Checked = True Then
                        txtGrossPay.Text = 8000
                    End If

                ElseIf String.Compare(strSecurityGuard, txtposition.Text, True) = 0 Then
                    intRDB = 5
                    If rdbA.Checked = True Then
                        txtGrossPay.Text = 6000
                    ElseIf rdbB.Checked = True Then
                        txtGrossPay.Text = 5000
                    End If
                ElseIf String.Compare(strnull, txtPosition.Text) Then
                    MessageBox.Show("Invalid Position")
                    intRDB = 0
                Else
                    MessageBox.Show("Invalid Position")
                End If
            End If
        End If
    End Sub

    Private Sub rdbA_Click(sender As Object, e As EventArgs) Handles rdbA.Click
        If intRDB = 0 Then
            txtGrossPay.Text = 0
        ElseIf intRDB = 1 Then
            txtGrossPay.Text = 25000
        ElseIf intRDB = 2 Then
            txtGrossPay.Text = 20000
        ElseIf intRDB = 3 Then
            txtGrossPay.Text = 15000
        ElseIf intRDB = 4 Then
            txtGrossPay.Text = 10000
        ElseIf intRDB = 5 Then
            txtGrossPay.Text = 6000
        End If

        If chkCooperative.Checked = True Then
            doubleCoop = Val(txtTax.Text) + Val(txtSalaryLoan.Text) + Val(txtOtherDeduction.Text) + 50
            txtNetPay.Text = Val(txtGrossPay.Text) - doubleCoop
            txtTax.Focus()
        ElseIf chkCooperative.Checked = False Then
            txtNetPay.Text = (Val(txtGrossPay.Text) - (Val(txtTax.Text) + Val(txtSalaryLoan.Text) + Val(txtOtherDeduction.Text)))
            txtTax.Focus()
        End If
    End Sub

    Private Sub rdbB_Click(sender As Object, e As EventArgs) Handles rdbB.Click
        If intRDB = 0 Then
            txtGrossPay.Text = 0
        ElseIf intRDB = 1 Then
            txtGrossPay.Text = 23000
        ElseIf intRDB = 2 Then
            txtGrossPay.Text = 18000
        ElseIf intRDB = 3 Then
            txtGrossPay.Text = 13000
        ElseIf intRDB = 4 Then
            txtGrossPay.Text = 8000
        ElseIf intRDB = 5 Then
            txtGrossPay.Text = 5000
        End If

        If chkCooperative.Checked = True Then
            doubleCoop = Val(txtTax.Text) + Val(txtSalaryLoan.Text) + Val(txtOtherDeduction.Text) + 50
            txtNetPay.Text = Val(txtGrossPay.Text) - doubleCoop
            txtTax.Focus()
        ElseIf chkCooperative.Checked = False Then
            txtNetPay.Text = (Val(txtGrossPay.Text) - (Val(txtTax.Text) + Val(txtSalaryLoan.Text) + Val(txtOtherDeduction.Text)))
            txtTax.Focus()
        End If
    End Sub

    Private Sub chkCooperative_CheckedChanged(Sender As Object, e As EventArgs) Handles chkCooperative.CheckedChanged
        If chkCooperative.Checked = True Then
            doubleCoop = Val(txtTax.Text) + Val(txtSalaryLoan.Text) + Val(txtOtherDeduction.Text) + 50
            txtNetPay.Text = Val(txtGrossPay.Text) - doubleCoop
            txtTax.Focus()
        ElseIf chkCooperative.Checked = False Then
            txtNetPay.Text = (Val(txtGrossPay.Text) - (Val(txtTax.Text) + Val(txtSalaryLoan.Text) + Val(txtOtherDeduction.Text)))
            txtTax.Focus()
        End If

    End Sub

    Private Sub txtTax_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTax.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 13 Then
            If Asc(e.KeyChar) = 13 Then
                txtSalaryLoan.Focus()
            End If
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtTax_KeyUp(sender As Object, e As KeyEventArgs) Handles txtTax.KeyUp
        If chkCooperative.Checked = True Then
            doubleCoop = Val(txtTax.Text) + Val(txtSalaryLoan.Text) + Val(txtOtherDeduction.Text) + 50
            txtNetPay.Text = Val(txtGrossPay.Text) - doubleCoop
        ElseIf chkCooperative.Checked = False Then
            txtNetPay.Text = (Val(txtGrossPay.Text) - (Val(txtTax.Text) + Val(txtSalaryLoan.Text) + Val(txtOtherDeduction.Text)))
        End If
    End Sub

    Private Sub txtSalaryLoan_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSalaryLoan.KeyUp
        If chkCooperative.Checked = True Then
            doubleCoop = Val(txtTax.Text) + Val(txtSalaryLoan.Text) + Val(txtOtherDeduction.Text) + 50
            txtNetPay.Text = Val(txtGrossPay.Text) - doubleCoop
        ElseIf chkCooperative.Checked = False Then
            txtNetPay.Text = (Val(txtGrossPay.Text) - (Val(txtTax.Text) + Val(txtSalaryLoan.Text) + Val(txtOtherDeduction.Text)))
        End If
    End Sub

    Private Sub txtSalaryLoan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSalaryLoan.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 13 Then
            If Asc(e.KeyChar) = 13 Then
                txtOtherDeduction.Focus()
            End If
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtOtherDeduction_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOtherDeduction.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 13 Then
            If Asc(e.KeyChar) = 13 Then
                btnAnother.Focus()
            End If
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtOtherDeduction_KeyUp(sender As Object, e As KeyEventArgs) Handles txtOtherDeduction.KeyUp
        If chkCooperative.Checked = True Then
            doubleCoop = Val(txtTax.Text) + Val(txtSalaryLoan.Text) + Val(txtOtherDeduction.Text) + 50
            txtNetPay.Text = Val(txtGrossPay.Text) - doubleCoop
        ElseIf chkCooperative.Checked = False Then
            txtNetPay.Text = (Val(txtGrossPay.Text) - (Val(txtTax.Text) + Val(txtSalaryLoan.Text) + Val(txtOtherDeduction.Text)))
        End If
    End Sub

    Private Sub btnAnother_Click(sender As Object, e As EventArgs) Handles btnAnother.Click
        txtName.Clear()
        txtPosition.Clear()
        rdbA.Checked = False
        rdbB.Checked = False
        txtGrossPay.Clear()
        chkCooperative.Checked = False
        txtTax.Clear()
        txtSalaryLoan.Clear()
        txtOtherDeduction.Clear()
        txtNetPay.Clear()
        intRDB = 0
        txtName.Focus()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End
    End Sub
End Class
