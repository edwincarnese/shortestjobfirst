Public Class SJF

    Dim holdWaiting_B As Double
    Dim holdWaiting_C As Double
    Dim holdWaiting_D As Double
    Dim holdWaiting_E As Double

    Dim holdTurnAround_B As Double
    Dim holdTurnAround_C As Double
    Dim holdTurnAround_D As Double
    Dim holdTurnAround_E As Double

    Dim holdWT_B As Double
    Dim holdWT_C As Double
    Dim holdWT_D As Double
    Dim holdWT_E As Double


    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click


        If txtArrivalTime_1.Text = "" Or txtArrivalTime_2.Text = "" Or txtArrivalTime_3.Text = "" Or txtArrivalTime_4.Text = "" Or txtArrivalTime_5.Text = "" Or txtCPUBurst_1.Text = "" Or txtCPUBurst_2.Text = "" Or txtCPUBurst_3.Text = "" Or txtCPUBurst_4.Text = "" Or txtCPUBurst_5.Text = "" Then

            MsgBox("Please fillup the fields", MsgBoxStyle.Information)

        Else

            clearTextboxes()

            ProcessID_1.Text = txtProcessID_1.Text
            lblArrivalTime.Text = Val(txtArrivalTime_1.Text)
            lblArrivalTime_1.Text = Val(txtCPUBurst_1.Text) + Val(txtArrivalTime_1.Text)

            If (Val(lblArrivalTime_1.Text) >= Val(txtCPUBurst_2.Text)) And Val(txtCPUBurst_2.Text) <= Val(txtCPUBurst_3.Text) And Val(txtCPUBurst_2.Text) <= Val(txtCPUBurst_4.Text) And Val(txtCPUBurst_2.Text) <= Val(txtCPUBurst_5.Text) Then

                holdWT_B = Val(txtArrivalTime_2.Text)
                holdWaiting_B = Val(lblArrivalTime_1.Text)
                ProcessID_2.Text = txtProcessID_2.Text
                lblArrivalTime_2.Text = Val(txtCPUBurst_2.Text) + Val(lblArrivalTime_1.Text)
                holdTurnAround_B = Val(lblArrivalTime_2.Text)

                If (Val(lblArrivalTime_2.Text) >= Val(txtCPUBurst_3.Text)) And Val(txtCPUBurst_3.Text) <= Val(txtCPUBurst_4.Text) And Val(txtCPUBurst_3.Text) <= Val(txtCPUBurst_5.Text) Then

                    holdWT_C = Val(txtArrivalTime_3.Text)
                    holdWaiting_C = Val(lblArrivalTime_2.Text)
                    ProcessID_3.Text = txtProcessID_3.Text
                    lblArrivalTime_3.Text = Val(txtCPUBurst_3.Text) + Val(lblArrivalTime_2.Text)
                    holdTurnAround_C = Val(lblArrivalTime_3.Text)

                    If (Val(lblArrivalTime_3.Text) >= Val(txtCPUBurst_4.Text)) And Val(txtCPUBurst_4.Text) <= Val(txtCPUBurst_5.Text) Then

                        holdWT_D = Val(txtArrivalTime_4.Text)
                        holdWaiting_D = Val(lblArrivalTime_3.Text)
                        ProcessID_4.Text = txtProcessID_4.Text
                        lblArrivalTime_4.Text = Val(txtCPUBurst_4.Text) + Val(lblArrivalTime_3.Text)
                        holdTurnAround_D = Val(lblArrivalTime_4.Text)

                        If (Val(lblArrivalTime_4.Text) >= Val(txtCPUBurst_5.Text)) Then

                            holdWT_E = Val(txtArrivalTime_5.Text)
                            holdWaiting_E = Val(lblArrivalTime_4.Text)
                            ProcessID_5.Text = txtProcessID_5.Text
                            lblArrivalTime_5.Text = Val(txtCPUBurst_5.Text) + Val(lblArrivalTime_4.Text)
                            holdTurnAround_E = Val(lblArrivalTime_5.Text)

                        End If

                    ElseIf (Val(lblArrivalTime_3.Text) >= Val(txtCPUBurst_5.Text)) And Val(txtCPUBurst_4.Text) > Val(txtCPUBurst_5.Text) Then

                        holdWT_D = Val(txtArrivalTime_4.Text)
                        holdWaiting_D = Val(lblArrivalTime_3.Text)
                        ProcessID_4.Text = txtProcessID_5.Text
                        lblArrivalTime_4.Text = Val(txtCPUBurst_5.Text) + Val(lblArrivalTime_3.Text)
                        holdTurnAround_D = Val(lblArrivalTime_4.Text)

                        If (Val(lblArrivalTime_4.Text) >= Val(txtCPUBurst_4.Text)) Then

                            holdWT_E = Val(txtArrivalTime_4.Text)
                            holdWaiting_E = Val(lblArrivalTime_4.Text)
                            ProcessID_5.Text = txtProcessID_4.Text
                            lblArrivalTime_5.Text = Val(txtCPUBurst_4.Text) + Val(lblArrivalTime_4.Text)
                            holdTurnAround_E = Val(lblArrivalTime_5.Text)

                        End If

                    End If




                ElseIf (Val(lblArrivalTime_2.Text) >= Val(txtCPUBurst_4.Text)) And Val(txtCPUBurst_4.Text) < Val(txtCPUBurst_3.Text) And Val(txtCPUBurst_4.Text) <= Val(txtCPUBurst_5.Text) Then

                    holdWT_C = Val(txtArrivalTime_4.Text)
                    holdWaiting_C = Val(lblArrivalTime_2.Text)
                    ProcessID_3.Text = txtProcessID_4.Text
                    lblArrivalTime_3.Text = Val(txtCPUBurst_4.Text) + Val(lblArrivalTime_2.Text)
                    holdTurnAround_C = Val(lblArrivalTime_3.Text)

                    If (Val(lblArrivalTime_3.Text) >= Val(txtCPUBurst_3.Text)) And Val(txtCPUBurst_3.Text) <= Val(txtCPUBurst_5.Text) Then

                        holdWT_D = Val(txtArrivalTime_3.Text)
                        holdWaiting_D = Val(lblArrivalTime_2.Text)
                        ProcessID_4.Text = txtProcessID_3.Text
                        lblArrivalTime_4.Text = Val(txtCPUBurst_3.Text) + Val(lblArrivalTime_3.Text)
                        holdTurnAround_D = Val(lblArrivalTime_4.Text)

                        If (Val(lblArrivalTime_4.Text) >= Val(txtCPUBurst_5.Text)) Then

                            holdWT_E = Val(txtArrivalTime_5.Text)
                            holdWaiting_E = Val(lblArrivalTime_4.Text)
                            ProcessID_5.Text = txtProcessID_5.Text
                            lblArrivalTime_5.Text = Val(txtCPUBurst_5.Text) + Val(lblArrivalTime_4.Text)
                            holdTurnAround_E = Val(lblArrivalTime_5.Text)

                        End If

                    ElseIf (Val(lblArrivalTime_3.Text) >= Val(txtCPUBurst_5.Text)) And Val(txtCPUBurst_5.Text) < Val(txtCPUBurst_3.Text) Then

                        holdWT_D = Val(txtArrivalTime_5.Text)
                        holdWaiting_D = Val(lblArrivalTime_3.Text)
                        ProcessID_4.Text = txtProcessID_5.Text
                        lblArrivalTime_4.Text = Val(txtCPUBurst_5.Text) + Val(lblArrivalTime_3.Text)
                        holdTurnAround_D = Val(lblArrivalTime_4.Text)

                        If (Val(lblArrivalTime_4.Text) >= Val(txtCPUBurst_3.Text)) Then

                            holdWT_E = Val(txtArrivalTime_3.Text)
                            holdWaiting_E = Val(lblArrivalTime_4.Text)
                            ProcessID_5.Text = txtProcessID_3.Text
                            lblArrivalTime_5.Text = Val(txtCPUBurst_3.Text) + Val(lblArrivalTime_4.Text)
                            holdTurnAround_E = Val(lblArrivalTime_5.Text)

                        End If

                    End If

                ElseIf (Val(lblArrivalTime_2.Text) >= Val(txtCPUBurst_5.Text)) And Val(txtCPUBurst_5.Text) < Val(txtCPUBurst_3.Text) And Val(txtCPUBurst_5.Text) < Val(txtCPUBurst_4.Text) Then

                    holdWT_C = Val(txtArrivalTime_5.Text)
                    holdWaiting_C = Val(lblArrivalTime_2.Text)
                    ProcessID_3.Text = txtProcessID_5.Text
                    lblArrivalTime_3.Text = Val(txtCPUBurst_5.Text) + Val(lblArrivalTime_2.Text)
                    holdTurnAround_C = Val(lblArrivalTime_3.Text)

                    If (Val(lblArrivalTime_3.Text) >= Val(txtCPUBurst_3.Text)) And Val(txtCPUBurst_3.Text) <= Val(txtCPUBurst_4.Text) Then

                        holdWT_D = Val(txtArrivalTime_3.Text)
                        holdWaiting_D = Val(lblArrivalTime_3.Text)
                        ProcessID_4.Text = txtProcessID_3.Text
                        lblArrivalTime_4.Text = Val(txtCPUBurst_3.Text) + Val(lblArrivalTime_3.Text)
                        holdTurnAround_D = Val(lblArrivalTime_4.Text)

                        If (Val(lblArrivalTime_4.Text) >= Val(txtCPUBurst_4.Text)) Then

                            holdWT_E = Val(txtArrivalTime_4.Text)
                            holdWaiting_E = Val(lblArrivalTime_4.Text)
                            ProcessID_5.Text = txtProcessID_4.Text
                            lblArrivalTime_4.Text = Val(txtCPUBurst_4.Text) + Val(lblArrivalTime_4.Text)
                            holdTurnAround_E = Val(lblArrivalTime_4.Text)

                        End If

                    End If

                End If




                'DONE B WEEEEEEEEEE








            ElseIf (Val(lblArrivalTime_1.Text) >= Val(txtCPUBurst_3.Text)) And Val(txtCPUBurst_3.Text) <= Val(txtCPUBurst_4.Text) And Val(txtCPUBurst_3.Text) <= Val(txtCPUBurst_5.Text) Then

                holdWT_B = Val(txtArrivalTime_3.Text)
                holdWaiting_B = Val(lblArrivalTime_1.Text)
                ProcessID_2.Text = txtProcessID_3.Text
                lblArrivalTime_2.Text = Val(txtCPUBurst_3.Text) + Val(lblArrivalTime_1.Text)
                holdTurnAround_B = Val(lblArrivalTime_2.Text)

                If (Val(lblArrivalTime_2.Text) >= Val(txtCPUBurst_2.Text)) And Val(txtCPUBurst_2.Text) <= Val(txtCPUBurst_4.Text) And Val(txtCPUBurst_2.Text) <= Val(txtCPUBurst_5.Text) Then

                    holdWT_C = Val(txtArrivalTime_2.Text)
                    holdWaiting_C = Val(lblArrivalTime_2.Text)
                    ProcessID_3.Text = txtProcessID_2.Text
                    lblArrivalTime_3.Text = Val(txtCPUBurst_2.Text) + Val(lblArrivalTime_2.Text)
                    holdTurnAround_C = Val(lblArrivalTime_3.Text)

                    If (Val(lblArrivalTime_3.Text) >= Val(txtCPUBurst_4.Text)) And Val(txtCPUBurst_4.Text) <= Val(txtCPUBurst_5.Text) Then

                        holdWT_D = Val(txtArrivalTime_4.Text)
                        holdWaiting_D = Val(lblArrivalTime_3.Text)
                        ProcessID_4.Text = txtProcessID_4.Text
                        lblArrivalTime_4.Text = Val(txtCPUBurst_4.Text) + Val(lblArrivalTime_3.Text)
                        holdTurnAround_D = Val(lblArrivalTime_4.Text)

                        If (Val(lblArrivalTime_4.Text) >= Val(txtCPUBurst_5.Text)) Then

                            holdWT_E = Val(txtArrivalTime_5.Text)
                            holdWaiting_E = Val(lblArrivalTime_4.Text)
                            ProcessID_5.Text = txtProcessID_5.Text
                            lblArrivalTime_5.Text = Val(txtCPUBurst_5.Text) + Val(lblArrivalTime_4.Text)
                            holdTurnAround_E = Val(lblArrivalTime_5.Text)

                        End If

                    ElseIf (Val(lblArrivalTime_3.Text) >= Val(txtCPUBurst_5.Text)) And Val(txtCPUBurst_5.Text) < Val(txtCPUBurst_4.Text) Then

                        holdWT_D = Val(txtArrivalTime_5.Text)
                        holdWaiting_D = Val(lblArrivalTime_3.Text)
                        ProcessID_4.Text = txtProcessID_5.Text
                        lblArrivalTime_4.Text = Val(txtCPUBurst_5.Text) + Val(lblArrivalTime_3.Text)
                        holdTurnAround_D = Val(lblArrivalTime_4.Text)


                        If (Val(lblArrivalTime_4.Text) >= Val(txtCPUBurst_4.Text)) Then

                            holdWT_E = Val(txtArrivalTime_4.Text)
                            holdWaiting_E = Val(lblArrivalTime_4.Text)
                            ProcessID_5.Text = txtProcessID_4.Text
                            lblArrivalTime_5.Text = Val(txtCPUBurst_4.Text) + Val(lblArrivalTime_4.Text)
                            holdTurnAround_E = Val(lblArrivalTime_5.Text)

                        End If

                    End If


                ElseIf (Val(lblArrivalTime_2.Text) >= Val(txtCPUBurst_4.Text)) And Val(txtCPUBurst_4.Text) <= Val(txtCPUBurst_5.Text) Then

                    holdWT_C = Val(txtArrivalTime_4.Text)
                    holdWaiting_C = Val(lblArrivalTime_2.Text)
                    ProcessID_3.Text = txtProcessID_4.Text
                    lblArrivalTime_3.Text = Val(txtCPUBurst_4.Text) + Val(lblArrivalTime_2.Text)
                    holdTurnAround_C = Val(lblArrivalTime_3.Text)

                    If (Val(lblArrivalTime_3.Text) >= Val(txtCPUBurst_2.Text)) And Val(txtCPUBurst_2.Text) <= Val(txtCPUBurst_5.Text) Then

                        holdWT_D = Val(txtArrivalTime_2.Text)
                        holdWaiting_D = Val(lblArrivalTime_3.Text)
                        ProcessID_4.Text = txtProcessID_2.Text
                        lblArrivalTime_4.Text = Val(txtCPUBurst_2.Text) + Val(lblArrivalTime_3.Text)
                        holdTurnAround_D = Val(lblArrivalTime_4.Text)

                        If Val(lblArrivalTime_4.Text) >= Val(txtCPUBurst_5.Text) Then

                            holdWT_E = Val(txtArrivalTime_5.Text)
                            holdWaiting_E = Val(lblArrivalTime_4.Text)
                            ProcessID_5.Text = txtProcessID_5.Text
                            lblArrivalTime_5.Text = Val(txtCPUBurst_5.Text) + Val(lblArrivalTime_4.Text)
                            holdTurnAround_E = Val(lblArrivalTime_5.Text)

                        End If


                    ElseIf (Val(lblArrivalTime_3.Text) >= Val(txtCPUBurst_5.Text)) And Val(txtCPUBurst_5.Text) < Val(txtCPUBurst_2.Text) Then

                        holdWT_D = Val(txtArrivalTime_5.Text)
                        holdWaiting_D = Val(lblArrivalTime_3.Text)
                        ProcessID_4.Text = txtProcessID_5.Text
                        lblArrivalTime_4.Text = Val(txtCPUBurst_5.Text) + Val(lblArrivalTime_3.Text)
                        holdTurnAround_D = Val(lblArrivalTime_4.Text)

                        If Val(lblArrivalTime_4.Text) >= Val(txtCPUBurst_2.Text) Then

                            holdWT_E = Val(txtArrivalTime_2.Text)
                            holdWaiting_E = Val(lblArrivalTime_4.Text)
                            ProcessID_5.Text = txtProcessID_2.Text
                            lblArrivalTime_5.Text = Val(txtCPUBurst_2.Text) + Val(lblArrivalTime_4.Text)
                            holdTurnAround_E = Val(lblArrivalTime_5.Text)

                        End If

                    End If

                ElseIf (Val(lblArrivalTime_2.Text) >= Val(txtCPUBurst_5.Text)) And Val(txtCPUBurst_5.Text) < Val(txtCPUBurst_2.Text) And Val(txtCPUBurst_5.Text) < Val(txtCPUBurst_4.Text) Then

                    holdWT_C = Val(txtArrivalTime_5.Text)
                    holdWaiting_C = Val(lblArrivalTime_2.Text)
                    ProcessID_3.Text = txtProcessID_5.Text
                    lblArrivalTime_3.Text = Val(txtCPUBurst_5.Text) + Val(lblArrivalTime_2.Text)
                    holdTurnAround_C = Val(lblArrivalTime_3.Text)

                    If (Val(lblArrivalTime_3.Text) >= Val(txtCPUBurst_2.Text)) And Val(txtCPUBurst_2.Text) <= Val(txtCPUBurst_4.Text) Then

                        holdWT_D = Val(txtArrivalTime_2.Text)
                        holdWaiting_D = Val(lblArrivalTime_3.Text)
                        ProcessID_4.Text = txtProcessID_2.Text
                        lblArrivalTime_4.Text = Val(txtCPUBurst_2.Text) + Val(lblArrivalTime_3.Text)
                        holdTurnAround_D = Val(lblArrivalTime_4.Text)

                        If Val(lblArrivalTime_4.Text) >= Val(txtCPUBurst_4.Text) Then

                            holdWT_E = Val(txtArrivalTime_4.Text)
                            holdWaiting_E = Val(lblArrivalTime_2.Text)
                            ProcessID_5.Text = txtProcessID_4.Text
                            lblArrivalTime_5.Text = Val(txtCPUBurst_4.Text) + Val(lblArrivalTime_4.Text)
                            holdTurnAround_E = Val(lblArrivalTime_5.Text)

                        End If

                    ElseIf (Val(lblArrivalTime_3.Text) >= Val(txtCPUBurst_4.Text)) And Val(txtCPUBurst_4.Text) < Val(txtCPUBurst_2.Text) Then

                        holdWT_D = Val(txtArrivalTime_4.Text)
                        holdWaiting_D = Val(lblArrivalTime_3.Text)
                        ProcessID_4.Text = txtProcessID_4.Text
                        lblArrivalTime_4.Text = Val(txtCPUBurst_4.Text) + Val(lblArrivalTime_3.Text)
                        holdTurnAround_D = Val(lblArrivalTime_4.Text)

                        If Val(lblArrivalTime_4.Text) >= Val(txtCPUBurst_2.Text) Then

                            holdWT_E = Val(txtArrivalTime_2.Text)
                            holdWaiting_E = Val(lblArrivalTime_4.Text)
                            ProcessID_5.Text = txtProcessID_2.Text
                            lblArrivalTime_5.Text = Val(txtCPUBurst_2.Text) + Val(lblArrivalTime_4.Text)
                            holdTurnAround_E = Val(lblArrivalTime_5.Text)

                        End If

                    End If




                End If




                'DONE C WEEEEEEEEEEEEEEEEEEEE









            ElseIf (Val(lblArrivalTime_1.Text) >= Val(txtCPUBurst_4.Text)) And Val(txtCPUBurst_4.Text) <= Val(txtCPUBurst_5.Text) And Val(txtCPUBurst_4.Text) < Val(txtCPUBurst_2.Text) And Val(txtCPUBurst_4.Text) < Val(txtCPUBurst_3.Text) Then

                holdWT_B = Val(txtArrivalTime_4.Text)
                holdWaiting_B = Val(lblArrivalTime_1.Text)
                ProcessID_2.Text = txtProcessID_4.Text
                lblArrivalTime_2.Text = Val(txtCPUBurst_4.Text) + Val(lblArrivalTime_1.Text)
                holdTurnAround_B = Val(lblArrivalTime_2.Text)

                If (Val(lblArrivalTime_2.Text) >= Val(txtCPUBurst_2.Text)) And Val(txtCPUBurst_2.Text) <= Val(txtCPUBurst_3.Text) And Val(txtCPUBurst_2.Text) <= Val(txtCPUBurst_5.Text) Then

                    holdWT_C = Val(txtArrivalTime_2.Text)
                    holdWaiting_C = Val(lblArrivalTime_2.Text)
                    ProcessID_3.Text = txtProcessID_2.Text
                    lblArrivalTime_3.Text = Val(txtCPUBurst_2.Text) + Val(lblArrivalTime_2.Text)
                    holdTurnAround_C = Val(lblArrivalTime_3.Text)

                    If (Val(lblArrivalTime_3.Text) >= Val(txtCPUBurst_3.Text)) And Val(txtCPUBurst_3.Text) <= Val(txtCPUBurst_5.Text) Then

                        holdWT_D = Val(txtArrivalTime_3.Text)
                        holdWaiting_D = Val(lblArrivalTime_3.Text)
                        ProcessID_4.Text = txtProcessID_3.Text
                        lblArrivalTime_4.Text = Val(txtCPUBurst_3.Text) + Val(lblArrivalTime_3.Text)
                        holdTurnAround_D = Val(lblArrivalTime_4.Text)

                        If Val(lblArrivalTime_4.Text) >= Val(txtCPUBurst_5.Text) Then

                            holdWT_E = Val(txtArrivalTime_5.Text)
                            holdWaiting_E = Val(lblArrivalTime_4.Text)
                            ProcessID_5.Text = txtProcessID_5.Text
                            lblArrivalTime_5.Text = Val(txtCPUBurst_5.Text) + Val(lblArrivalTime_4.Text)
                            holdTurnAround_E = Val(lblArrivalTime_5.Text)

                        End If

                    ElseIf (Val(lblArrivalTime_3.Text) >= Val(txtCPUBurst_5.Text)) And Val(txtCPUBurst_5.Text) < Val(txtCPUBurst_3.Text) Then

                        holdWT_D = Val(txtArrivalTime_5.Text)
                        holdWaiting_D = Val(lblArrivalTime_3.Text)
                        ProcessID_4.Text = txtProcessID_5.Text
                        lblArrivalTime_4.Text = Val(txtCPUBurst_5.Text) + Val(lblArrivalTime_3.Text)
                        holdTurnAround_D = Val(lblArrivalTime_4.Text)

                        If Val(lblArrivalTime_4.Text) >= Val(txtCPUBurst_3.Text) Then

                            holdWT_E = Val(txtArrivalTime_3.Text)
                            holdWaiting_E = Val(lblArrivalTime_4.Text)
                            ProcessID_5.Text = txtProcessID_3.Text
                            lblArrivalTime_5.Text = Val(txtCPUBurst_3.Text) + Val(lblArrivalTime_4.Text)
                            holdTurnAround_E = Val(lblArrivalTime_5.Text)

                        End If


                    End If



                ElseIf (Val(lblArrivalTime_2.Text) >= Val(txtCPUBurst_3.Text)) And Val(txtCPUBurst_3.Text) <= Val(txtCPUBurst_5.Text) And Val(txtCPUBurst_3.Text) < Val(txtCPUBurst_2.Text) Then

                    holdWT_C = Val(txtArrivalTime_3.Text)
                    holdWaiting_C = Val(lblArrivalTime_2.Text)
                    ProcessID_3.Text = txtProcessID_3.Text
                    lblArrivalTime_3.Text = Val(txtCPUBurst_3.Text) + Val(lblArrivalTime_2.Text)
                    holdTurnAround_C = Val(lblArrivalTime_3.Text)

                    If (Val(lblArrivalTime_3.Text) >= Val(txtCPUBurst_2.Text)) And Val(txtCPUBurst_2.Text) <= Val(txtCPUBurst_5.Text) Then

                        holdWT_D = Val(txtArrivalTime_2.Text)
                        holdWaiting_D = Val(lblArrivalTime_3.Text)
                        ProcessID_4.Text = txtProcessID_2.Text
                        lblArrivalTime_4.Text = Val(txtCPUBurst_2.Text) + Val(lblArrivalTime_3.Text)
                        holdTurnAround_D = Val(lblArrivalTime_4.Text)

                        If Val(lblArrivalTime_4.Text) >= Val(txtCPUBurst_5.Text) Then

                            holdWT_E = Val(txtArrivalTime_5.Text)
                            holdWaiting_E = Val(lblArrivalTime_4.Text)
                            ProcessID_5.Text = txtProcessID_5.Text
                            lblArrivalTime_5.Text = Val(txtCPUBurst_5.Text) + Val(lblArrivalTime_4.Text)
                            holdTurnAround_E = Val(lblArrivalTime_5.Text)

                        End If

                    ElseIf (Val(lblArrivalTime_3.Text) >= Val(txtCPUBurst_5.Text)) And Val(txtCPUBurst_5.Text) < Val(txtCPUBurst_2.Text) Then

                        holdWT_D = Val(txtArrivalTime_5.Text)
                        holdWaiting_D = Val(lblArrivalTime_3.Text)
                        ProcessID_4.Text = txtProcessID_5.Text
                        lblArrivalTime_4.Text = Val(txtCPUBurst_5.Text) + Val(lblArrivalTime_3.Text)
                        holdTurnAround_D = Val(lblArrivalTime_4.Text)

                        If Val(lblArrivalTime_4.Text) >= Val(txtCPUBurst_2.Text) Then

                            holdWT_E = Val(txtArrivalTime_2.Text)
                            holdWaiting_E = Val(lblArrivalTime_4.Text)
                            ProcessID_5.Text = txtProcessID_2.Text
                            lblArrivalTime_5.Text = Val(txtCPUBurst_2.Text) + Val(lblArrivalTime_4.Text)
                            holdTurnAround_E = Val(lblArrivalTime_5.Text)

                        End If

                    End If




                ElseIf (Val(lblArrivalTime_2.Text) >= Val(txtCPUBurst_5.Text)) And Val(txtCPUBurst_5.Text) < Val(txtCPUBurst_2.Text) And Val(txtCPUBurst_5.Text) < Val(txtCPUBurst_3.Text) Then

                    holdWT_C = Val(txtArrivalTime_5.Text)
                    holdWaiting_C = Val(lblArrivalTime_2.Text)
                    ProcessID_3.Text = txtProcessID_5.Text
                    lblArrivalTime_3.Text = Val(txtCPUBurst_5.Text) + Val(lblArrivalTime_2.Text)
                    holdTurnAround_C = Val(lblArrivalTime_3.Text)

                    If (Val(lblArrivalTime_3.Text) >= Val(txtCPUBurst_2.Text)) And Val(txtCPUBurst_2.Text) <= Val(txtCPUBurst_3.Text) Then

                        holdWT_D = Val(txtArrivalTime_2.Text)
                        holdWaiting_D = Val(lblArrivalTime_3.Text)
                        ProcessID_4.Text = txtProcessID_2.Text
                        lblArrivalTime_4.Text = Val(txtCPUBurst_2.Text) + Val(lblArrivalTime_3.Text)
                        holdTurnAround_D = Val(lblArrivalTime_4.Text)

                        If Val(lblArrivalTime_4.Text) >= Val(txtCPUBurst_3.Text) Then

                            holdWT_E = Val(txtArrivalTime_3.Text)
                            holdWaiting_E = Val(lblArrivalTime_4.Text)
                            ProcessID_5.Text = txtProcessID_3.Text
                            lblArrivalTime_5.Text = Val(txtCPUBurst_3.Text) + Val(lblArrivalTime_4.Text)
                            holdTurnAround_E = Val(lblArrivalTime_5.Text)

                        End If

                    ElseIf (Val(lblArrivalTime_3.Text) >= Val(txtCPUBurst_3.Text)) And Val(txtCPUBurst_3.Text) < Val(txtCPUBurst_2.Text) Then

                        holdWT_D = Val(txtArrivalTime_3.Text)
                        holdWaiting_D = Val(lblArrivalTime_3.Text)
                        ProcessID_4.Text = txtProcessID_3.Text
                        lblArrivalTime_4.Text = Val(txtCPUBurst_3.Text) + Val(lblArrivalTime_3.Text)
                        holdTurnAround_D = Val(lblArrivalTime_4.Text)

                        If Val(lblArrivalTime_4.Text) >= Val(txtCPUBurst_2.Text) Then

                            holdWT_E = Val(txtArrivalTime_2.Text)
                            holdWaiting_E = Val(lblArrivalTime_4.Text)
                            ProcessID_5.Text = txtProcessID_2.Text
                            lblArrivalTime_5.Text = Val(txtCPUBurst_2.Text) + Val(lblArrivalTime_4.Text)
                            holdTurnAround_E = Val(lblArrivalTime_5.Text)

                        End If

                    End If

                End If





                'DONE D WEEEEEEEEEEEEEEEEEE




            ElseIf (Val(lblArrivalTime_1.Text) >= Val(txtCPUBurst_5.Text)) And Val(txtCPUBurst_5.Text) < Val(txtCPUBurst_2.Text) And Val(txtCPUBurst_5.Text) < Val(txtCPUBurst_3.Text) And Val(txtCPUBurst_5.Text) < Val(txtCPUBurst_4.Text) Then

                holdWT_B = Val(txtArrivalTime_5.Text)
                holdWaiting_B = Val(lblArrivalTime_1.Text)
                ProcessID_2.Text = txtProcessID_5.Text
                lblArrivalTime_2.Text = Val(txtCPUBurst_5.Text) + Val(lblArrivalTime_1.Text)
                holdTurnAround_B = Val(lblArrivalTime_2.Text)

                If (Val(lblArrivalTime_2.Text) >= Val(txtCPUBurst_2.Text)) And Val(txtCPUBurst_2.Text) <= Val(txtCPUBurst_3.Text) And Val(txtCPUBurst_2.Text) <= Val(txtCPUBurst_4.Text) Then

                    holdWT_C = Val(txtArrivalTime_2.Text)
                    holdWaiting_C = Val(lblArrivalTime_2.Text)
                    ProcessID_3.Text = txtProcessID_2.Text
                    lblArrivalTime_3.Text = Val(txtCPUBurst_2.Text) + Val(lblArrivalTime_2.Text)
                    holdTurnAround_C = Val(lblArrivalTime_3.Text)

                    If (Val(lblArrivalTime_3.Text) >= Val(txtCPUBurst_3.Text)) And Val(txtCPUBurst_3.Text) <= Val(txtCPUBurst_4.Text) Then

                        holdWT_D = Val(txtArrivalTime_3.Text)
                        holdWaiting_D = Val(lblArrivalTime_3.Text)
                        ProcessID_4.Text = txtProcessID_3.Text
                        lblArrivalTime_4.Text = Val(txtCPUBurst_3.Text) + Val(lblArrivalTime_3.Text)
                        holdTurnAround_D = Val(lblArrivalTime_4.Text)

                        If Val(lblArrivalTime_4.Text) >= Val(txtCPUBurst_4.Text) Then

                            holdWT_E = Val(txtArrivalTime_4.Text)
                            holdWaiting_E = Val(lblArrivalTime_4.Text)
                            ProcessID_5.Text = txtProcessID_4.Text
                            lblArrivalTime_5.Text = Val(txtCPUBurst_4.Text) + Val(lblArrivalTime_4.Text)
                            holdTurnAround_E = Val(lblArrivalTime_5.Text)

                        End If

                    ElseIf (Val(lblArrivalTime_3.Text) >= Val(txtCPUBurst_4.Text)) And Val(txtCPUBurst_4.Text) < Val(txtCPUBurst_3.Text) Then

                        holdWT_C = Val(txtArrivalTime_4.Text)
                        holdWaiting_C = Val(lblArrivalTime_3.Text)
                        ProcessID_3.Text = txtProcessID_4.Text
                        lblArrivalTime_3.Text = Val(txtCPUBurst_4.Text) + Val(lblArrivalTime_2.Text)
                        holdTurnAround_C = Val(lblArrivalTime_3.Text)

                        If (Val(lblArrivalTime_3.Text) >= Val(txtCPUBurst_2.Text)) And Val(txtCPUBurst_2.Text) <= Val(txtCPUBurst_3.Text) Then

                            holdWT_D = Val(txtArrivalTime_2.Text)
                            holdWaiting_D = Val(lblArrivalTime_3.Text)
                            ProcessID_4.Text = txtProcessID_2.Text
                            lblArrivalTime_4.Text = Val(txtCPUBurst_2.Text) + Val(lblArrivalTime_3.Text)
                            holdTurnAround_D = Val(lblArrivalTime_4.Text)

                            If Val(lblArrivalTime_4.Text) >= Val(txtCPUBurst_3.Text) Then

                                holdWT_E = Val(txtArrivalTime_3.Text)
                                holdWaiting_E = Val(lblArrivalTime_4.Text)
                                ProcessID_5.Text = txtProcessID_3.Text
                                lblArrivalTime_5.Text = Val(txtCPUBurst_3.Text) + Val(lblArrivalTime_4.Text)
                                holdTurnAround_E = Val(lblArrivalTime_5.Text)

                            End If

                        End If

                    End If


                ElseIf (Val(lblArrivalTime_2.Text) >= Val(txtCPUBurst_3.Text)) And Val(txtCPUBurst_3.Text) <= Val(txtCPUBurst_4.Text) And Val(txtCPUBurst_3.Text) < Val(txtCPUBurst_2.Text) Then

                    holdWT_C = Val(txtArrivalTime_3.Text)
                    holdWaiting_C = Val(lblArrivalTime_2.Text)
                    ProcessID_3.Text = txtProcessID_3.Text
                    lblArrivalTime_3.Text = Val(txtCPUBurst_3.Text) + Val(lblArrivalTime_2.Text)
                    holdTurnAround_C = Val(lblArrivalTime_3.Text)

                    If (Val(lblArrivalTime_3.Text) >= Val(txtCPUBurst_2.Text)) And Val(txtCPUBurst_2.Text) <= Val(txtCPUBurst_4.Text) Then

                        holdWT_D = Val(txtArrivalTime_2.Text)
                        holdWaiting_D = Val(lblArrivalTime_3.Text)
                        ProcessID_4.Text = txtProcessID_2.Text
                        lblArrivalTime_4.Text = Val(txtCPUBurst_2.Text) + Val(lblArrivalTime_3.Text)
                        holdTurnAround_D = Val(lblArrivalTime_4.Text)

                        If Val(lblArrivalTime_4.Text) >= Val(txtCPUBurst_4.Text) Then

                            holdWT_E = Val(txtArrivalTime_4.Text)
                            holdWaiting_E = Val(lblArrivalTime_4.Text)
                            ProcessID_5.Text = txtProcessID_4.Text
                            lblArrivalTime_5.Text = Val(txtCPUBurst_4.Text) + Val(lblArrivalTime_4.Text)
                            holdTurnAround_E = Val(lblArrivalTime_5.Text)

                        End If

                    ElseIf (Val(lblArrivalTime_3.Text) >= Val(txtCPUBurst_4.Text)) And Val(txtCPUBurst_4.Text) < Val(txtCPUBurst_2.Text) Then

                        holdWT_D = Val(txtArrivalTime_4.Text)
                        holdWaiting_D = Val(lblArrivalTime_3.Text)
                        ProcessID_4.Text = txtProcessID_4.Text
                        lblArrivalTime_4.Text = Val(txtCPUBurst_4.Text) + Val(lblArrivalTime_3.Text)
                        holdTurnAround_D = Val(lblArrivalTime_4.Text)

                        If Val(lblArrivalTime_4.Text) >= Val(txtCPUBurst_2.Text) Then

                            holdWT_E = Val(txtArrivalTime_2.Text)
                            holdWaiting_E = Val(lblArrivalTime_4.Text)
                            ProcessID_5.Text = txtProcessID_2.Text
                            lblArrivalTime_5.Text = Val(txtCPUBurst_2.Text) + Val(lblArrivalTime_4.Text)
                            holdTurnAround_E = Val(lblArrivalTime_5.Text)

                        End If

                    End If



                ElseIf (Val(lblArrivalTime_2.Text) >= Val(txtCPUBurst_4.Text)) And Val(txtCPUBurst_4.Text) < Val(txtCPUBurst_2.Text) And Val(txtCPUBurst_4.Text) < Val(txtCPUBurst_3.Text) Then

                    holdWT_C = Val(txtArrivalTime_4.Text)
                    holdWaiting_C = Val(lblArrivalTime_2.Text)
                    ProcessID_3.Text = txtProcessID_4.Text
                    lblArrivalTime_3.Text = Val(txtCPUBurst_4.Text) + Val(lblArrivalTime_2.Text)
                    holdTurnAround_C = Val(lblArrivalTime_3.Text)

                    If (Val(lblArrivalTime_3.Text) >= Val(txtCPUBurst_3.Text)) And Val(txtCPUBurst_3.Text) < Val(txtCPUBurst_2.Text) Then

                        holdWT_D = Val(txtArrivalTime_3.Text)
                        holdWaiting_D = Val(lblArrivalTime_3.Text)
                        ProcessID_4.Text = txtProcessID_3.Text
                        lblArrivalTime_4.Text = Val(txtCPUBurst_3.Text) + Val(lblArrivalTime_3.Text)
                        holdTurnAround_D = Val(lblArrivalTime_4.Text)

                        If Val(lblArrivalTime_4.Text) >= Val(txtCPUBurst_2.Text) Then

                            holdWT_E = Val(txtArrivalTime_2.Text)
                            holdWaiting_E = Val(lblArrivalTime_4.Text)
                            ProcessID_5.Text = txtProcessID_2.Text
                            lblArrivalTime_5.Text = Val(txtCPUBurst_2.Text) + Val(lblArrivalTime_4.Text)
                            holdTurnAround_E = Val(lblArrivalTime_5.Text)

                        End If

                    ElseIf (Val(lblArrivalTime_3.Text) >= Val(txtCPUBurst_2.Text)) And Val(txtCPUBurst_2.Text) <= Val(txtCPUBurst_3.Text) Then

                        holdWT_D = Val(txtArrivalTime_2.Text)
                        holdWaiting_D = Val(lblArrivalTime_3.Text)
                        ProcessID_4.Text = txtProcessID_2.Text
                        lblArrivalTime_4.Text = Val(txtCPUBurst_2.Text) + Val(lblArrivalTime_3.Text)
                        holdTurnAround_D = Val(lblArrivalTime_4.Text)

                        If Val(lblArrivalTime_4.Text) >= Val(txtCPUBurst_3.Text) Then

                            holdWT_E = Val(txtArrivalTime_3.Text)
                            holdWaiting_E = Val(lblArrivalTime_4.Text)
                            ProcessID_5.Text = txtProcessID_3.Text
                            lblArrivalTime_5.Text = Val(txtCPUBurst_3.Text) + Val(lblArrivalTime_4.Text)
                            holdTurnAround_E = Val(lblArrivalTime_5.Text)

                        End If

                    End If


                End If




                'DONE E WEEEEEEEEEEEE


            End If

            getWaitingTime()

            getTurnAroundTime()

        End If



        ' WHAT'S DONE IS DONE  WEEEEEEEEEEEEE



    End Sub


    Private Sub getWaitingTime()

        txtWT_1.Text = ProcessID_1.Text
        txtWT_2.Text = ProcessID_2.Text
        txtWT_3.Text = ProcessID_3.Text
        txtWT_4.Text = ProcessID_4.Text
        txtWT_5.Text = ProcessID_5.Text

        txtWaitingTime_1.Text = Val(txtArrivalTime_1.Text) - Val(txtArrivalTime_1.Text)
        txtWaitingTime_2.Text = holdWaiting_B - holdWT_B
        txtWaitingTime_3.Text = holdWaiting_C - holdWT_C
        txtWaitingTime_4.Text = holdWaiting_D - holdWT_D
        txtWaitingTime_5.Text = holdWaiting_E - holdWT_E

        txtTotalWaitingTime.Text = Val(txtWaitingTime_1.Text) + Val(txtWaitingTime_2.Text) + Val(txtWaitingTime_3.Text) + Val(txtWaitingTime_4.Text) + Val(txtWaitingTime_5.Text)
        txtAverageWaitingTime.Text = Val(txtTotalWaitingTime.Text) / 5

    End Sub

    Private Sub getTurnAroundTime()

        txtTA_1.Text = ProcessID_1.Text
        txtTA_2.Text = ProcessID_2.Text
        txtTA_3.Text = ProcessID_3.Text
        txtTA_4.Text = ProcessID_4.Text
        txtTA_5.Text = ProcessID_5.Text

        txtTurnAroundTime_1.Text = Val(txtCPUBurst_1.Text) - Val(txtArrivalTime_1.Text)
        txtTurnAroundTime_2.Text = holdTurnAround_B - holdWT_B
        txtTurnAroundTime_3.Text = holdTurnAround_C - holdWT_C
        txtTurnAroundTime_4.Text = holdTurnAround_D - holdWT_D
        txtTurnAroundTime_5.Text = holdTurnAround_E - holdWT_E

        txtTotalTurnAroundTime.Text = Val(txtTurnAroundTime_1.Text) + Val(txtTurnAroundTime_2.Text) + Val(txtTurnAroundTime_3.Text) + Val(txtTurnAroundTime_4.Text) + Val(txtTurnAroundTime_5.Text)
        txtAverageTurnAroundTime.Text = Val(txtTotalTurnAroundTime.Text) / 5

    End Sub


    Private Sub clearTextboxes()

        ProcessID_1.Text = ""
        ProcessID_2.Text = ""
        ProcessID_3.Text = ""
        ProcessID_4.Text = ""
        ProcessID_5.Text = ""

        lblArrivalTime.Text = ""
        lblArrivalTime_1.Text = ""
        lblArrivalTime_2.Text = ""
        lblArrivalTime_3.Text = ""
        lblArrivalTime_4.Text = ""
        lblArrivalTime_5.Text = ""

    End Sub



End Class