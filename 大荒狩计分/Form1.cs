using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;

namespace 大荒狩计分
{
    public partial class dhsForm : Form
    {
        public const double TIMES_12 = 1.0;
        public const double TIMES_15 = 1.4;
        public const int LZ_6 = 50;
        public const int LZ_5 = 20;
        public const int LZ_4 = 10;
        public const int SP02 = 150;
        public const int SP04 = 100;
        public const int BHYY_VALUE = 30;
        public const int TST_VALUE = 40;
        public const int GSJG_VALUE = 40;
        public const int SRWJ_VALUE = 50;
        public const int HCWSH_VALUE = 60;
        public const int YLZZ_VALUE = 70;
        public const int BNWR_VALUE = 80;
        public const int WZXJ_VALUE = 80;
        public const int RZW_VALUE = 100;
        public const int SYS_VALUE = 60;
        public const int SL_VALUE = 100;
        public const int F3YIGE_VALUE = 30;
        public const int HHCD_VALUE = 30;
        public const int YXWM_VALUE = 30;
        public const int YXWM_JS = 15;
        public const int YXWM_WL = 150;
        public const int ZYSZ_VALUE = 50;
        public const int ZYSZ_JS = 40;
        public const int ZYSZ_WL = 200;
        public const int LWWL_VALUE = 10;
        public const int WEYS_VALUE = 0;
        public const int SHZX_VALUE = 130;
        public const int SMZS_VALUE = 50;
        public const int XWZO_VALUE = 150;
        public const int YD_VALUE = 70;
        public const int SB_VALUE = 350;
        public const int SGZS_VALUE = 140;
        public const int MRYH_VALUE = 200;
        public const int YINCANG = 10;
        public const int CANGPIN = 10;
        public const int BANZI = 5;
        public const int RBAN_LV1 = 50;
        public const int RBAN_LV2 = 30;

        public int jinJiPoint = 0;
        public int bhyyNum = 0;
        public int tstNum = 0;
        public int gsjgNum = 0;
        public int srwjNum = 0;
        public int hcwshNum = 0;
        public int ylzzNum = 0;
        public int bnwrNum = 0;
        public int wzxjNum = 0;
        public int rzwNum = 0;
        public int sysNum = 0;
        public int slNum = 0;
        public int lwwlNum = 0;

        public int f3YiGe = 0;

        public int teShuPoint = 0;
        public int yxwmPoint = 0;
        public int yxwmNum = 0;
        public int zyszPoint = 0;
        public int zyszNum = 0;

        public int ycPoint = 0;
        public int ycNum = 0;

        public int lzPoint = 0;
        public int lz6Num = 0;
        public int lz5Num = 0;
        public int lz4Num = 0;

        public int jjPoint = 0;
        public int jjPoint1 = 0;
        public int jjPoint2 = 0;
        public int jjPoint3 = 0;
        public int sp02Point = 0;
        public int sp04Point = 0;

        public int cpbzPoint = 0;
        public int cpNum = 0;
        public int bzNum = 0;

        public int rbanPoint = 0;

        public double times = 0;

        public int jsPoint = 0;

        public int total = 0;
        public dhsForm()
        {
            InitializeComponent();
        }

        private void bhyyMinus_Click(object sender, EventArgs e)
        {
            if (bhyyNum > 0)
            {
                bhyyNum--;
                bhyyNumShow.Text = bhyyNum.ToString();
                jinJiPoint -= BHYY_VALUE;
                jinJiPointShow.Text = jinJiPoint.ToString();
            }
        }

        private void bhyyPlus_Click(object sender, EventArgs e)
        {
            bhyyNum++;
            bhyyNumShow.Text = bhyyNum.ToString();
            jinJiPoint += BHYY_VALUE;
            jinJiPointShow.Text = jinJiPoint.ToString();
        }

        private void tstMinus_Click(object sender, EventArgs e)
        {
            if (tstNum > 0)
            {
                tstNum--;
                tstNumShow.Text = tstNum.ToString();
                jinJiPoint -= TST_VALUE;
                jinJiPointShow.Text = jinJiPoint.ToString();
            }
        }

        private void tstPlus_Click(object sender, EventArgs e)
        {
            tstNum++;
            tstNumShow.Text = tstNum.ToString();
            jinJiPoint += TST_VALUE;
            jinJiPointShow.Text = jinJiPoint.ToString();
        }

        private void gsjgMinus_Click(object sender, EventArgs e)
        {
            if (gsjgNum > 0)
            {
                gsjgNum--;
                gsjgNumShow.Text = gsjgNum.ToString();
                jinJiPoint -= GSJG_VALUE;
                jinJiPointShow.Text = jinJiPoint.ToString();
            }
        }

        private void gsjgPlus_Click(object sender, EventArgs e)
        {
            gsjgNum++;
            gsjgNumShow.Text = gsjgNum.ToString();
            jinJiPoint += GSJG_VALUE;
            jinJiPointShow.Text = jinJiPoint.ToString();
        }

        private void srwjMinus_Click(object sender, EventArgs e)
        {
            if (srwjNum > 0)
            {
                srwjNum--;
                srwjNumShow.Text = srwjNum.ToString();
                jinJiPoint -= SRWJ_VALUE;
                jinJiPointShow.Text = jinJiPoint.ToString();
            }
        }

        private void srwjPlus_Click(object sender, EventArgs e)
        {
            srwjNum++;
            srwjNumShow.Text = srwjNum.ToString();
            jinJiPoint += SRWJ_VALUE;
            jinJiPointShow.Text = jinJiPoint.ToString();
        }

        private void hcwshMinus_Click(object sender, EventArgs e)
        {
            if (hcwshNum > 0)
            {
                hcwshNum--;
                hcwshNumShow.Text = hcwshNum.ToString();
                jinJiPoint -= HCWSH_VALUE;
                jinJiPointShow.Text = jinJiPoint.ToString();
            }
        }

        private void hcwshPlus_Click(object sender, EventArgs e)
        {
            hcwshNum++;
            hcwshNumShow.Text = hcwshNum.ToString();
            jinJiPoint += HCWSH_VALUE;
            jinJiPointShow.Text = jinJiPoint.ToString();
        }

        private void ylzzMinus_Click(object sender, EventArgs e)
        {
            if (ylzzNum > 0)
            {
                ylzzNum--;
                ylzzNumShow.Text = ylzzNum.ToString();
                jinJiPoint -= YLZZ_VALUE;
                jinJiPointShow.Text = jinJiPoint.ToString();
            }
        }

        private void ylzzPlus_Click(object sender, EventArgs e)
        {
            ylzzNum++;
            ylzzNumShow.Text = ylzzNum.ToString();
            jinJiPoint += YLZZ_VALUE;
            jinJiPointShow.Text = jinJiPoint.ToString();
        }

        private void bnwrMinus_Click(object sender, EventArgs e)
        {
            if (bnwrNum > 0)
            {
                bnwrNum--;
                bnwrNumShow.Text = bnwrNum.ToString();
                jinJiPoint -= BNWR_VALUE;
                jinJiPointShow.Text = jinJiPoint.ToString();
            }
        }

        private void bnwrPlus_Click(object sender, EventArgs e)
        {
            bnwrNum++;
            bnwrNumShow.Text = bnwrNum.ToString();
            jinJiPoint += BNWR_VALUE;
            jinJiPointShow.Text = jinJiPoint.ToString();
        }

        private void wzxjMinus_Click(object sender, EventArgs e)
        {
            if (wzxjNum > 0)
            {
                wzxjNum--;
                wzxjNumShow.Text = wzxjNum.ToString();
                jinJiPoint -= WZXJ_VALUE;
                jinJiPointShow.Text = jinJiPoint.ToString();
            }
        }

        private void wzxjPlus_Click(object sender, EventArgs e)
        {
            wzxjNum++;
            wzxjNumShow.Text = wzxjNum.ToString();
            jinJiPoint += WZXJ_VALUE;
            jinJiPointShow.Text = jinJiPoint.ToString();
        }

        private void rzwMinus_Click(object sender, EventArgs e)
        {
            if (rzwNum > 0)
            {
                rzwNum--;
                rzwNumShow.Text = rzwNum.ToString();
                jinJiPoint -= RZW_VALUE;
                jinJiPointShow.Text = jinJiPoint.ToString();
            }
        }

        private void rzwPlus_Click(object sender, EventArgs e)
        {
            rzwNum++;
            rzwNumShow.Text = rzwNum.ToString();
            jinJiPoint += RZW_VALUE;
            jinJiPointShow.Text = jinJiPoint.ToString();
        }

        private void sysMinus_Click(object sender, EventArgs e)
        {
            if (sysNum > 0)
            {
                sysNum--;
                sysNumShow.Text = sysNum.ToString();
                jinJiPoint -= SYS_VALUE;
                jinJiPointShow.Text = jinJiPoint.ToString();
            }
        }

        private void sysPlus_Click(object sender, EventArgs e)
        {
            sysNum++;
            sysNumShow.Text = sysNum.ToString();
            jinJiPoint += SYS_VALUE;
            jinJiPointShow.Text = jinJiPoint.ToString();
        }

        private void slMinus_Click(object sender, EventArgs e)
        {
            if (slNum > 0)
            {
                slNum--;
                slNumShow.Text = slNum.ToString();
                jinJiPoint -= SL_VALUE;
                jinJiPointShow.Text = jinJiPoint.ToString();
            }
        }

        private void slPlus_Click(object sender, EventArgs e)
        {
            slNum++;
            slNumShow.Text = slNum.ToString();
            jinJiPoint += SL_VALUE;
            jinJiPointShow.Text = jinJiPoint.ToString();
        }

        private void lwwlMinus_Click(object sender, EventArgs e)
        {
            if (lwwlNum > 0)
            {
                lwwlNum--;
                lwwlNumShow.Text = lwwlNum.ToString();
                jinJiPoint -= LWWL_VALUE;
                jinJiPointShow.Text = jinJiPoint.ToString();
            }
        }

        private void lwwlPlus_Click(object sender, EventArgs e)
        {
            lwwlNum++;
            lwwlNumShow.Text = lwwlNum.ToString();
            jinJiPoint += LWWL_VALUE;
            jinJiPointShow.Text = jinJiPoint.ToString();
        }

        private void hhcdSx_CheckedChanged(object sender, EventArgs e)
        {
            if (hhcdSx.Checked)
            {
                teShuPoint += HHCD_VALUE;
                teShuPointShow.Text = teShuPoint.ToString();
            }
            else if (!hhcdSx.Checked)
            {
                teShuPoint -= HHCD_VALUE;
                teShuPointShow.Text = teShuPoint.ToString();
            }
        }

        private void yxwmTg_CheckedChanged(object sender, EventArgs e)
        {
            if (yxwmTg.Checked)
            {
                yxwmNum = 0;
                yxwmNumShow.Text = yxwmNum.ToString();
                yxwmPoint = YXWM_VALUE;
                teShuPoint += YXWM_VALUE;
                teShuPointShow.Text = teShuPoint.ToString();
                yxwmJs.Enabled = true;
                yxwmMinus.Enabled = true;
                yxwmNumShow.Enabled = true;
                yxwmPlus.Enabled = true;
            }
            else if (!yxwmTg.Checked)
            {
                yxwmNum = 0;
                yxwmNumShow.Text = yxwmNum.ToString();
                teShuPoint -= yxwmPoint;
                yxwmPoint = 0;
                teShuPointShow.Text = teShuPoint.ToString();
                yxwmJs.Enabled = false;
                yxwmMinus.Enabled = false;
                yxwmNumShow.Enabled = false;
                yxwmPlus.Enabled = false;
            }
        }

        private void yxwmMinus_Click(object sender, EventArgs e)
        {
            if (yxwmNum > 0)
            {
                yxwmNum--;
                yxwmNumShow.Text = yxwmNum.ToString();
                teShuPoint -= yxwmPoint;
                yxwmPoint = YXWM_VALUE + yxwmNum * YXWM_JS;
                teShuPoint += yxwmPoint;
                teShuPointShow.Text = teShuPoint.ToString();
            }
        }

        private void yxwmPlus_Click(object sender, EventArgs e)
        {
            if (yxwmNum < 6)
            {
                yxwmNum++;
                yxwmNumShow.Text = yxwmNum.ToString();
                yxwmPoint += YXWM_JS;
                teShuPoint += YXWM_JS;
                if (yxwmNum == 6)
                {
                    teShuPoint -= yxwmPoint;
                    yxwmPoint = YXWM_WL;
                    teShuPoint += yxwmPoint;
                }
                teShuPointShow.Text = teShuPoint.ToString();
            }
        }

        private void zyszTg_CheckedChanged(object sender, EventArgs e)
        {
            if (zyszTg.Checked)
            {
                zyszPoint += ZYSZ_VALUE;
                teShuPoint += ZYSZ_VALUE;
                teShuPointShow.Text = teShuPoint.ToString();
                zyszWl.Enabled = true;
                zyszJs.Enabled = true;
                zyszMinus.Enabled = true;
                zyszNumShow.Enabled = true;
                zyszPlus.Enabled = true;
                zyszNum = 0;
                zyszNumShow.Text = zyszNum.ToString();
            }
            else if (!zyszTg.Checked)
            {
                teShuPoint -= zyszPoint;
                zyszPoint = 0;
                teShuPointShow.Text = teShuPoint.ToString();
                zyszNum = 0;
                zyszNumShow.Text = zyszNum.ToString();
                zyszWl.Checked = false;
                zyszWl.Enabled = false;
                zyszJs.Enabled = false;
                zyszMinus.Enabled = false;
                zyszNumShow.Enabled = false;
                zyszPlus.Enabled = false;
            }
        }

        private void zyszWl_CheckedChanged(object sender, EventArgs e)
        {
            if (zyszWl.Checked)
            {
                zyszNum = 3;
                zyszNumShow.Text = zyszNum.ToString();
                zyszJs.Enabled = false;
                zyszMinus.Enabled = false;
                zyszNumShow.Enabled = false;
                zyszPlus.Enabled = false;
                teShuPoint -= zyszPoint;
                zyszPoint = ZYSZ_WL;
                teShuPoint += zyszPoint;
                teShuPointShow.Text = teShuPoint.ToString();
            }
            else if (!zyszWl.Checked)
            {
                if (zyszTg.Checked)
                {
                    zyszJs.Enabled = true;
                    zyszMinus.Enabled = true;
                    zyszNumShow.Enabled = true;
                    zyszPlus.Enabled = true;
                    teShuPoint -= zyszPoint;
                    zyszPoint = ZYSZ_VALUE + zyszNum * ZYSZ_JS;
                    teShuPoint += zyszPoint;
                    teShuPointShow.Text = teShuPoint.ToString();
                }
            }
        }

        private void zyszMinus_Click(object sender, EventArgs e)
        {
            if (zyszNum > 0)
            {
                zyszNum--;
                zyszNumShow.Text = zyszNum.ToString();
                zyszPoint -= ZYSZ_JS;
                teShuPoint -= ZYSZ_JS;
                teShuPointShow.Text = teShuPoint.ToString();
            }
        }

        private void zyszPlus_Click(object sender, EventArgs e)
        {
            if (zyszNum < 3)
            {
                zyszNum++;
                zyszNumShow.Text = zyszNum.ToString();
                zyszPoint += ZYSZ_JS;
                teShuPoint += ZYSZ_JS;
                teShuPointShow.Text = teShuPoint.ToString();
            }
        }

        private void lz6Minus_Click(object sender, EventArgs e)
        {
            if (lz6Num > 0)
            {
                lz6Num--;
                lz6NumShow.Text = lz6Num.ToString();
                lzPoint -= LZ_6;
                lzPointShow.Text = lzPoint.ToString();
            }
        }

        private void lz6Plus_Click(object sender, EventArgs e)
        {

            lz6Num++;
            lz6NumShow.Text = lz6Num.ToString();
            lzPoint += LZ_6;
            lzPointShow.Text = lzPoint.ToString();
        }

        private void lz5Minus_Click(object sender, EventArgs e)
        {
            if (lz5Num > 0)
            {
                lz5Num--;
                lz5NumShow.Text = lz5Num.ToString();
                lzPoint -= LZ_5;
                lzPointShow.Text = lzPoint.ToString();
            }
        }

        private void lz5Plus_Click(object sender, EventArgs e)
        {
            lz5Num++;
            lz5NumShow.Text = lz5Num.ToString();
            lzPoint += LZ_5;
            lzPointShow.Text = lzPoint.ToString();
        }

        private void lz4Minus_Click(object sender, EventArgs e)
        {
            if (lz4Num > 0)
            {
                lz4Num--;
                lz4NumShow.Text = lz4Num.ToString();
                lzPoint -= LZ_4;
                lzPointShow.Text = lzPoint.ToString();
            }
        }

        private void lz4Plus_Click(object sender, EventArgs e)
        {
            lz4Num++;
            lz4NumShow.Text = lz4Num.ToString();
            lzPoint += LZ_4;
            lzPointShow.Text = lzPoint.ToString();
        }

        private void weys_CheckedChanged(object sender, EventArgs e)
        {
            if (weys.Checked)
            {
                shzx.Checked = false;
                xwzo.Checked = false;
                smzs.Checked = false;
                jjPoint1 = WEYS_VALUE;
            }
            else if (!weys.Checked)
            {
                jjPoint1 = 0;
            }
            if ((sgzs.Checked || mryh.Checked) && ((yd.Checked || sb.Checked) || (smzs.Checked || xwzo.Checked)) && noSd.Checked)
            {
                sp02Point = SP02;
                tip02.Visible = true;
            }
            else
            {
                sp02Point = 0;
                tip02.Visible = false;
            }
            if ((sgzs.Checked || mryh.Checked) && ((smzs.Checked || xwzo.Checked) || shzx.Checked))
            {
                sp04Point = SP04;
                tip04.Visible = true;
            }
            else
            {
                sp04Point = 0;
                tip04.Visible = false;
            }
            jjPoint = jjPoint1 + jjPoint2 + jjPoint3 + sp02Point + sp04Point;
            jjPointShow.Text = jjPoint.ToString();
        }

        private void shzx_CheckedChanged(object sender, EventArgs e)
        {
            if (shzx.Checked)
            {
                weys.Checked = false;
                xwzo.Checked = false;
                smzs.Checked = false;
                jjPoint1 = SHZX_VALUE;
            }
            else if (!shzx.Checked)
            {
                jjPoint1 = 0;
            }
            if ((sgzs.Checked || mryh.Checked) && ((yd.Checked || sb.Checked) || (smzs.Checked || xwzo.Checked)) && noSd.Checked)
            {
                sp02Point = SP02;
                tip02.Visible = true;
            }
            else
            {
                sp02Point = 0;
                tip02.Visible = false;
            }
            if ((sgzs.Checked || mryh.Checked) && ((smzs.Checked || xwzo.Checked) || shzx.Checked))
            {
                sp04Point = SP04;
                tip04.Visible = true;
            }
            else
            {
                sp04Point = 0;
                tip04.Visible = false;
            }
            jjPoint = jjPoint1 + jjPoint2 + jjPoint3 + sp02Point + sp04Point;
            jjPointShow.Text = jjPoint.ToString();
        }

        private void smzs_CheckedChanged(object sender, EventArgs e)
        {
            if (smzs.Checked)
            {
                weys.Checked = false;
                xwzo.Checked = false;
                shzx.Checked = false;
                jjPoint1 = SMZS_VALUE;
            }
            else if (!smzs.Checked)
            {
                jjPoint1 = 0;
            }
            if ((sgzs.Checked || mryh.Checked) && ((yd.Checked || sb.Checked) || (smzs.Checked || xwzo.Checked)) && noSd.Checked)
            {
                sp02Point = SP02;
                tip02.Visible = true;
            }
            else
            {
                sp02Point = 0;
                tip02.Visible = false;
            }
            if ((sgzs.Checked || mryh.Checked) && ((smzs.Checked || xwzo.Checked) || shzx.Checked))
            {
                sp04Point = SP04;
                tip04.Visible = true;
            }
            else
            {
                sp04Point = 0;
                tip04.Visible = false;
            }
            jjPoint = jjPoint1 + jjPoint2 + jjPoint3 + sp02Point + sp04Point;
            jjPointShow.Text = jjPoint.ToString();
        }

        private void xwzo_CheckedChanged(object sender, EventArgs e)
        {
            if (xwzo.Checked)
            {
                weys.Checked = false;
                shzx.Checked = false;
                smzs.Checked = false;
                jjPoint1 = XWZO_VALUE;
            }
            else if (!xwzo.Checked)
            {
                jjPoint1 = 0;
            }
            if ((sgzs.Checked || mryh.Checked) && ((yd.Checked || sb.Checked) || (smzs.Checked || xwzo.Checked)) && noSd.Checked)
            {
                sp02Point = SP02;
                tip02.Visible = true;
            }
            else
            {
                sp02Point = 0;
                tip02.Visible = false;
            }
            if ((sgzs.Checked || mryh.Checked) && ((smzs.Checked || xwzo.Checked) || shzx.Checked))
            {
                sp04Point = SP04;
                tip04.Visible = true;
            }
            else
            {
                sp04Point = 0;
                tip04.Visible = false;
            }
            jjPoint = jjPoint1 + jjPoint2 + jjPoint3 + sp02Point + sp04Point;
            jjPointShow.Text = jjPoint.ToString();
        }

        private void yd_CheckedChanged(object sender, EventArgs e)
        {
            if (yd.Checked)
            {
                sb.Checked = false;
                jjPoint2 = YD_VALUE;
            }
            else if (!yd.Checked)
            {
                jjPoint2 = 0;
            }
            if ((sgzs.Checked || mryh.Checked) && ((yd.Checked || sb.Checked) || (smzs.Checked || xwzo.Checked)) && noSd.Checked)
            {
                sp02Point = SP02;
                tip02.Visible = true;
            }
            else
            {
                sp02Point = 0;
                tip02.Visible = false;
            }
            if ((sgzs.Checked || mryh.Checked) && ((smzs.Checked || xwzo.Checked) || shzx.Checked))
            {
                sp04Point = SP04;
                tip04.Visible = true;
            }
            else
            {
                sp04Point = 0;
                tip04.Visible = false;
            }
            jjPoint = jjPoint1 + jjPoint2 + jjPoint3 + sp02Point + sp04Point;
            jjPointShow.Text = jjPoint.ToString();
        }

        private void sb_CheckedChanged(object sender, EventArgs e)
        {
            if (sb.Checked)
            {
                yd.Checked = false;
                jjPoint2 = SB_VALUE;
            }
            else if (!sb.Checked)
            {
                jjPoint2 = 0;
            }
            if ((sgzs.Checked || mryh.Checked) && ((yd.Checked || sb.Checked) || (smzs.Checked || xwzo.Checked)) && noSd.Checked)
            {
                sp02Point = SP02;
                tip02.Visible = true;
            }
            else
            {
                sp02Point = 0;
                tip02.Visible = false;
            }
            if ((sgzs.Checked || mryh.Checked) && ((smzs.Checked || xwzo.Checked) || shzx.Checked))
            {
                sp04Point = SP04;
                tip04.Visible = true;
            }
            else
            {
                sp04Point = 0;
                tip04.Visible = false;
            }
            jjPoint = jjPoint1 + jjPoint2 + jjPoint3 + sp02Point + sp04Point;
            jjPointShow.Text = jjPoint.ToString();
        }

        private void sgzs_CheckedChanged(object sender, EventArgs e)
        {
            if (sgzs.Checked)
            {
                mryh.Checked = false;
                jjPoint3 = SGZS_VALUE;
            }
            else if (!sgzs.Checked)
            {
                jjPoint3 = 0;
            }
            if ((sgzs.Checked || mryh.Checked) && ((yd.Checked || sb.Checked) || (smzs.Checked || xwzo.Checked)) && noSd.Checked)
            {
                sp02Point = SP02;
                tip02.Visible = true;
            }
            else
            {
                sp02Point = 0;
                tip02.Visible = false;
            }
            if ((sgzs.Checked || mryh.Checked) && ((smzs.Checked || xwzo.Checked) || shzx.Checked))
            {
                sp04Point = SP04;
                tip04.Visible = true;
            }
            else
            {
                sp04Point = 0;
                tip04.Visible = false;
            }
            jjPoint = jjPoint1 + jjPoint2 + jjPoint3 + sp02Point + sp04Point;
            jjPointShow.Text = jjPoint.ToString();
        }

        private void mryh_CheckedChanged(object sender, EventArgs e)
        {
            if (mryh.Checked)
            {
                sgzs.Checked = false;
                jjPoint3 = MRYH_VALUE;
            }
            else if (!mryh.Checked)
            {
                jjPoint3 = 0;
            }
            if ((sgzs.Checked || mryh.Checked) && ((yd.Checked || sb.Checked) || (smzs.Checked || xwzo.Checked)) && noSd.Checked)
            {
                sp02Point = SP02;
                tip02.Visible = true;
            }
            else
            {
                sp02Point = 0;
                tip02.Visible = false;
            }
            if ((sgzs.Checked || mryh.Checked) && ((smzs.Checked || xwzo.Checked) || shzx.Checked))
            {
                sp04Point = SP04;
                tip04.Visible = true;
            }
            else
            {
                sp04Point = 0;
                tip04.Visible = false;
            }
            jjPoint = jjPoint1 + jjPoint2 + jjPoint3 + sp02Point + sp04Point;
            jjPointShow.Text = jjPoint.ToString();
        }

        private void noSd_CheckedChanged(object sender, EventArgs e)
        {
            if ((sgzs.Checked || mryh.Checked) && ((yd.Checked || sb.Checked) || (smzs.Checked || xwzo.Checked)) && noSd.Checked)
            {
                sp02Point = SP02;
                tip02.Visible = true;
            }
            else
            {
                sp02Point = 0;
                tip02.Visible = false;
            }
            if ((sgzs.Checked || mryh.Checked) && ((smzs.Checked || xwzo.Checked) || shzx.Checked))
            {
                sp04Point = SP04;
                tip04.Visible = true;
            }
            else
            {
                sp04Point = 0;
                tip04.Visible = false;
            }
            jjPoint = jjPoint1 + jjPoint2 + jjPoint3 + sp02Point + sp04Point;
            jjPointShow.Text = jjPoint.ToString();
        }

        private void ycMinus_Click(object sender, EventArgs e)
        {
            if (ycNum > 0)
            {
                ycNum--;
                ycNumShow.Text = ycNum.ToString();
                ycPoint -= YINCANG;
                ycPointShow.Text = ycPoint.ToString();
            }
        }

        private void ycPlus_Click(object sender, EventArgs e)
        {
            ycNum++;
            ycNumShow.Text = ycNum.ToString();
            ycPoint += YINCANG;
            ycPointShow.Text = ycPoint.ToString();
        }

        private void cpNumShow_TextChanged(object sender, EventArgs e)
        {
            if (cpNumShow.Text == "")
            {
                cpNum = 0;
            }
            else
            {
                cpNum = int.Parse(cpNumShow.Text);
            }
            cpbzPoint = cpNum * CANGPIN + bzNum * BANZI;
            cpbzPointShow.Text = cpbzPoint.ToString();
        }

        private void bzNumShow_TextChanged(object sender, EventArgs e)
        {
            if (bzNumShow.Text == "")
            {
                bzNum = 0;
            }
            else
            {
                bzNum = int.Parse(bzNumShow.Text);
            }
            cpbzPoint = cpNum * CANGPIN + bzNum * BANZI;
            cpbzPointShow.Text = cpbzPoint.ToString();
        }

        private void men_CheckedChanged(object sender, EventArgs e)
        {
            if (men.Checked)
            {
                rbanPoint += RBAN_LV1;
                rbanPointShow.Text = rbanPoint.ToString();
            }
            else
            {
                rbanPoint -= RBAN_LV1;
                rbanPointShow.Text += rbanPoint.ToString();
            }
        }

        private void yns_CheckedChanged(object sender, EventArgs e)
        {
            if (yns.Checked)
            {
                rbanPoint += RBAN_LV1;
                rbanPointShow.Text = rbanPoint.ToString();
            }
            else
            {
                rbanPoint -= RBAN_LV1;
                rbanPointShow.Text = rbanPoint.ToString();
            }
        }

        private void texas_CheckedChanged(object sender, EventArgs e)
        {
            if (texas.Checked)
            {
                rbanPoint += RBAN_LV1;
                rbanPointShow.Text = rbanPoint.ToString();
            }
            else
            {
                rbanPoint -= RBAN_LV1;
                rbanPointShow.Text = rbanPoint.ToString();
            }
        }

        private void yedao_CheckedChanged(object sender, EventArgs e)
        {
            if (yedao.Checked)
            {
                rbanPoint += RBAN_LV1;
                rbanPointShow.Text = rbanPoint.ToString();
            }
            else
            {
                rbanPoint -= RBAN_LV1;
                rbanPointShow.Text = rbanPoint.ToString();
            }
        }

        private void yanw_CheckedChanged(object sender, EventArgs e)
        {
            if (yanw.Checked)
            {
                rbanPoint += RBAN_LV1;
                rbanPointShow.Text = rbanPoint.ToString();
            }
            else
            {
                rbanPoint -= RBAN_LV1;
                rbanPointShow.Text = rbanPoint.ToString();
            }
        }

        private void jian_CheckedChanged(object sender, EventArgs e)
        {
            if (jian.Checked)
            {
                rbanPoint += RBAN_LV1;
                rbanPointShow.Text = rbanPoint.ToString();
            }
            else
            {
                rbanPoint -= RBAN_LV1;
                rbanPointShow.Text = rbanPoint.ToString();
            }
        }

        private void chuna_CheckedChanged(object sender, EventArgs e)
        {
            if (chuna.Checked)
            {
                rbanPoint += RBAN_LV2;
                rbanPointShow.Text = rbanPoint.ToString();
            }
            else
            {
                rbanPoint -= RBAN_LV2;
                rbanPointShow.Text = rbanPoint.ToString();
            }
        }

        private void shu_CheckedChanged(object sender, EventArgs e)
        {
            if (shu.Checked)
            {
                rbanPoint += RBAN_LV2;
                rbanPointShow.Text = rbanPoint.ToString();
            }
            else
            {
                rbanPoint -= RBAN_LV2;
                rbanPointShow.Text = rbanPoint.ToString();
            }
        }

        private void zhuod_CheckedChanged(object sender, EventArgs e)
        {
            if (zhuod.Checked)
            {
                rbanPoint += RBAN_LV2;
                rbanPointShow.Text = rbanPoint.ToString();
            }
            else
            {
                rbanPoint -= RBAN_LV2;
                rbanPointShow.Text = rbanPoint.ToString();
            }
        }

        private void ela_CheckedChanged(object sender, EventArgs e)
        {
            if (ela.Checked)
            {
                rbanPoint += RBAN_LV2;
                rbanPointShow.Text = rbanPoint.ToString();
            }
            else
            {
                rbanPoint -= RBAN_LV2;
                rbanPointShow.Text = rbanPoint.ToString();
            }
        }

        public int calculate()
        {
            double tot;
            tot = Math.Ceiling(times * (jsPoint + jinJiPoint + teShuPoint + f3YiGe + ycPoint + jjPoint + cpbzPoint + lzPoint + rbanPoint));
            return (int)tot;
        }
        private void act_Click(object sender, EventArgs e)
        {
            if (times > 0)
            {
                total = calculate();
                totalShow.Text = total.ToString();
                if (total >= 3500)
                {
                    totalShow.Text += "!";
                }
                totalShow.Visible = true;
            }
            else
            {
                DialogResult Warning = System.Windows.Forms.MessageBox.Show("请选择难度！",
                                 "未选择难度", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void n12_CheckedChanged(object sender, EventArgs e)
        {
            if (n12.Checked)
            {
                n15.Checked = false;
                times = TIMES_12;
            }
            else
            {
                times = 0;
            }
        }

        private void n15_CheckedChanged(object sender, EventArgs e)
        {
            if (n15.Checked)
            {
                n12.Checked = false;
                times = TIMES_15;
            }
            else
            {
                times = 0;
            }
        }

        private void jsPointShow_TextChanged(object sender, EventArgs e)
        {
            if (jsPointShow.Text == "")
            {
                jsPoint = 0;
            }
            jsPoint = int.Parse(jsPointShow.Text);
        }

        private void isF3YiGe_CheckedChanged(object sender, EventArgs e)
        {
            if (isF3YiGe.Checked)
            {
                f3YiGe = F3YIGE_VALUE;
                f3YiGePointShow.Text = f3YiGe.ToString();
            }
            else
            {
                f3YiGe = 0;
                f3YiGePointShow.Text = f3YiGe.ToString();
            }
        }

        private void restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Process.GetCurrentProcess()?.Kill();
        }
    }
}
