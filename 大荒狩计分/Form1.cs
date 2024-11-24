using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;

namespace 大荒狩计分
{
    public partial class dhsForm : Form
    {
        public const double TIMES_12 = 1.0;
        public const double TIMES_15 = 1.4;
        public const int LZ_6 = 20;
        public const int LZ_5 = 10;
        public const int LZ_4 = 5;
        public const int KLMD_VALUE = 10;
        public const int ND_KLMD_VALUE = 15;
        public const int DQYP_KNND_VALUE = 10;
        public const int XHYD_VALUE = 15;
        public const int MW_XHYD_VALUE = 30;
        public const int JXDC_MWND_VALUE = 15;
        public const int XBKC_TZND_VALUE = 25;
        public const int JRCCX_VALUE = 35;
        public const int TDFS_VALUE = 60;
        public const int ND_TDFS_VALUE = 35;
        public const int JHGZ_VALUE = 25;
        public const int ND_JHGZ_VALUE = 45;
        public const int SSDKQ_VALUE = 35;
        public const int ND_SSDKQ_VALUE = 35;
        public const int MQGS_VALUE = 25;
        public const int ND_MQGS_VALUE = 45;
        public const int _4_XY_5_VALUE = 10;
        public const int JRND_VALUE = 5;
        public const int TZ_NDDC_VALUE = 15;
        public const int F3YIGE_VALUE = 20;
        public const int SBDSD_VALUE = 15;
        public const int XHD_VALUE = 20;
        public const int JXJS_VALUE = 20;
        public const int WJDBF_VALUE = 30;
        public const int ZCCM_VALUE = 20;
        public const int TS_JJ = 10;
        public const int YSGL_VALUE = 0;
        public int[] YSGL_JS = { 0, 15, 25, 45, 55 };
        public int[] YSGL_JJ_JS = { 0, 25, 35, 45, 60 };
        public const int YSGL_JS3_WL = 60;
        public const int YSGL_JJ_JS4_WL = 70;
        public const int JJSK_VALUE = 10;
        public const int CY_VALUE = 100;
        public const int SC_VALUE = 250;
        public const int JJ14_LIANDA = 50;
        public const int JJ24_LIANDA = 150;
        public const int JJSK_YG = 50;
        public const int JJ_ND = 40;
        public const int JJ_HL = 40;
        public const int JJ_DD_ND = 50;
        public const int JJ_DD_HL = 60;
        public const int YINCANG = 5;
        public const int GX = 1;
        public const int MT = 10;
        public const int GGG = 10;
        public const int CANGPIN = 10;
        public const int BANZI = 5;
        public const int RBAN_LV1 = 50;
        public const int RBAN_LV2 = 30;

        public int jinJiPoint = 0;
        public int bhyyNum = 0;
        public int ndKlmdNum = 0;
        public int tstNum = 0;
        public int gsjgNum = 0;
        public int mwXhydNum = 0;
        public int srwjNum = 0;
        public int hcwshNum = 0;
        public int ylzzNum = 0;
        public int bnwrNum = 0;
        public int ndTdfsNum = 0;
        public int wzxjNum = 0;
        public int ndJhgzNum = 0;
        public int rzwNum = 0;
        public int ndSsdkqNum = 0;
        public int sysNum = 0;
        public int ndMqgsNum = 0;
        public int slNum = 0;
        public int lwwlNum = 0;
        public int _4xy5Num = 0;
        public int jrndNum = 0;
        public int tzNddcNum = 0;

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
        public int jjskPointTot = 0;
        public int jjskPoint = 0;
        public int jjskYgPoint = 0;
        public int jjskNdPoint = 0;
        public int jjskHlPoint = 0;
        public int cyPointTot = 0;
        public int cyPoint = 0;
        public int cyNdPoint = 0;
        public int cyHlPoint = 0;
        public int scPointTot = 0;
        public int scPoint = 0;
        public int scNdPoint = 0;
        public int scHlPoint = 0;
        public int lianDaPoint = 0;

        public int sxPoint = 0;
        public int cpNum = 0;
        public int sxNum = 0;
        public int fdNum = 0;

        public int xzPoint = 0;

        public int yeQ = 0;
        public int yeH = 0;

        public int jsPoint = 0;

        public int pbPoint = 0;
        public int ansjmPoint = 0;
        public double xzcjMult = 1;
        public double gdxzMult = 1;

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
                jinJiPoint -= KLMD_VALUE;
                jinJiPointShow.Text = jinJiPoint.ToString();
            }
        }

        private void bhyyPlus_Click(object sender, EventArgs e)
        {
            bhyyNum++;
            bhyyNumShow.Text = bhyyNum.ToString();
            jinJiPoint += KLMD_VALUE;
            jinJiPointShow.Text = jinJiPoint.ToString();
        }

        private void ndKlmdMinus_Click(object sender, EventArgs e)
        {
            if (ndKlmdNum > 0)
            {
                ndKlmdNum--;
                ndKlmdNumShow.Text = ndKlmdNum.ToString();
                jinJiPoint -= ND_KLMD_VALUE;
                jinJiPointShow.Text = jinJiPoint.ToString();
            }
        }

        private void ndKlmdPlus_Click(object sender, EventArgs e)
        {
            ndKlmdNum++;
            ndKlmdNumShow.Text = ndKlmdNum.ToString();
            jinJiPoint += ND_KLMD_VALUE;
            jinJiPointShow.Text = jinJiPoint.ToString();
        }

        private void tstMinus_Click(object sender, EventArgs e)
        {
            if (tstNum > 0)
            {
                tstNum--;
                tstNumShow.Text = tstNum.ToString();
                jinJiPoint -= DQYP_KNND_VALUE;
                jinJiPointShow.Text = jinJiPoint.ToString();
            }
        }

        private void tstPlus_Click(object sender, EventArgs e)
        {
            tstNum++;
            tstNumShow.Text = tstNum.ToString();
            jinJiPoint += DQYP_KNND_VALUE;
            jinJiPointShow.Text = jinJiPoint.ToString();
        }

        private void gsjgMinus_Click(object sender, EventArgs e)
        {
            if (gsjgNum > 0)
            {
                gsjgNum--;
                gsjgNumShow.Text = gsjgNum.ToString();
                jinJiPoint -= XHYD_VALUE;
                jinJiPointShow.Text = jinJiPoint.ToString();
            }
        }

        private void gsjgPlus_Click(object sender, EventArgs e)
        {
            gsjgNum++;
            gsjgNumShow.Text = gsjgNum.ToString();
            jinJiPoint += XHYD_VALUE;
            jinJiPointShow.Text = jinJiPoint.ToString();
        }

        private void mwXhydMinus_Click(object sender, EventArgs e)
        {
            if (mwXhydNum > 0)
            {
                mwXhydNum--;
                //mwXhydNumShow.Text = mwXhydNum.ToString();
                jinJiPoint -= MW_XHYD_VALUE;
                jinJiPointShow.Text = jinJiPoint.ToString();
            }
        }

        private void mwXhydPlus_Click(object sender, EventArgs e)
        {
            mwXhydNum++;
            //mwXhydNumShow.Text = mwXhydNum.ToString();
            jinJiPoint += MW_XHYD_VALUE;
            jinJiPointShow.Text = jinJiPoint.ToString();
        }

        private void srwjMinus_Click(object sender, EventArgs e)
        {
            if (srwjNum > 0)
            {
                srwjNum--;
                srwjNumShow.Text = srwjNum.ToString();
                jinJiPoint -= JXDC_MWND_VALUE;
                jinJiPointShow.Text = jinJiPoint.ToString();
            }
        }

        private void srwjPlus_Click(object sender, EventArgs e)
        {
            srwjNum++;
            srwjNumShow.Text = srwjNum.ToString();
            jinJiPoint += JXDC_MWND_VALUE;
            jinJiPointShow.Text = jinJiPoint.ToString();
        }

        private void hcwshMinus_Click(object sender, EventArgs e)
        {
            if (hcwshNum > 0)
            {
                hcwshNum--;
                hcwshNumShow.Text = hcwshNum.ToString();
                jinJiPoint -= XBKC_TZND_VALUE;
                jinJiPointShow.Text = jinJiPoint.ToString();
            }
        }

        private void hcwshPlus_Click(object sender, EventArgs e)
        {
            hcwshNum++;
            hcwshNumShow.Text = hcwshNum.ToString();
            jinJiPoint += XBKC_TZND_VALUE;
            jinJiPointShow.Text = jinJiPoint.ToString();
        }

        private void ylzzMinus_Click(object sender, EventArgs e)
        {
            if (ylzzNum > 0)
            {
                ylzzNum--;
                ylzzNumShow.Text = ylzzNum.ToString();
                jinJiPoint -= JRCCX_VALUE;
                jinJiPointShow.Text = jinJiPoint.ToString();
            }
        }

        private void ylzzPlus_Click(object sender, EventArgs e)
        {
            ylzzNum++;
            ylzzNumShow.Text = ylzzNum.ToString();
            jinJiPoint += JRCCX_VALUE;
            jinJiPointShow.Text = jinJiPoint.ToString();
        }

        private void bnwrMinus_Click(object sender, EventArgs e)
        {
            if (bnwrNum > 0)
            {
                bnwrNum--;
                bnwrNumShow.Text = bnwrNum.ToString();
                jinJiPoint -= TDFS_VALUE;
                jinJiPointShow.Text = jinJiPoint.ToString();
            }
        }

        private void bnwrPlus_Click(object sender, EventArgs e)
        {
            bnwrNum++;
            bnwrNumShow.Text = bnwrNum.ToString();
            jinJiPoint += TDFS_VALUE;
            jinJiPointShow.Text = jinJiPoint.ToString();
        }

        private void ndTdfsMinus_Click(object sender, EventArgs e)
        {
            if (ndTdfsNum > 0)
            {
                ndTdfsNum--;
                //ndTdfsNumShow.Text = ndTdfsNum.ToString();
                jinJiPoint -= ND_TDFS_VALUE;
                jinJiPointShow.Text = jinJiPoint.ToString();
            }
        }

        private void ndTdfsPlus_Click(object sender, EventArgs e)
        {
            ndTdfsNum++;
            //ndTdfsNumShow.Text = ndTdfsNum.ToString();
            jinJiPoint += ND_TDFS_VALUE;
            jinJiPointShow.Text = jinJiPoint.ToString();
        }

        private void wzxjMinus_Click(object sender, EventArgs e)
        {
            if (wzxjNum > 0)
            {
                wzxjNum--;
                wzxjNumShow.Text = wzxjNum.ToString();
                jinJiPoint -= JHGZ_VALUE;
                jinJiPointShow.Text = jinJiPoint.ToString();
            }
        }

        private void wzxjPlus_Click(object sender, EventArgs e)
        {
            wzxjNum++;
            wzxjNumShow.Text = wzxjNum.ToString();
            jinJiPoint += JHGZ_VALUE;
            jinJiPointShow.Text = jinJiPoint.ToString();
        }

        private void ndJhgzMinus_Click(object sender, EventArgs e)
        {
            if (ndJhgzNum > 0)
            {
                ndJhgzNum--;
                ndJhgzNumShow.Text = ndJhgzNum.ToString();
                jinJiPoint -= ND_JHGZ_VALUE;
                jinJiPointShow.Text = jinJiPoint.ToString();
            }
        }

        private void ndJhgzPlus_Click(object sender, EventArgs e)
        {
            ndJhgzNum++;
            ndJhgzNumShow.Text = ndJhgzNum.ToString();
            jinJiPoint += ND_JHGZ_VALUE;
            jinJiPointShow.Text = jinJiPoint.ToString();
        }

        private void rzwMinus_Click(object sender, EventArgs e)
        {
            if (rzwNum > 0)
            {
                rzwNum--;
                rzwNumShow.Text = rzwNum.ToString();
                jinJiPoint -= SSDKQ_VALUE;
                jinJiPointShow.Text = jinJiPoint.ToString();
            }
        }

        private void rzwPlus_Click(object sender, EventArgs e)
        {
            rzwNum++;
            rzwNumShow.Text = rzwNum.ToString();
            jinJiPoint += SSDKQ_VALUE;
            jinJiPointShow.Text = jinJiPoint.ToString();
        }

        private void ndSsdkqMinus_Click(object sender, EventArgs e)
        {
            if (ndSsdkqNum > 0)
            {
                ndSsdkqNum--;
                ndSsdkqNumShow.Text = ndSsdkqNum.ToString();
                jinJiPoint -= ND_SSDKQ_VALUE;
                jinJiPointShow.Text = jinJiPoint.ToString();
            }
        }

        private void ndSsdkqPlus_Click(object sender, EventArgs e)
        {
            ndSsdkqNum++;
            ndSsdkqNumShow.Text = ndSsdkqNum.ToString();
            jinJiPoint += ND_SSDKQ_VALUE;
            jinJiPointShow.Text = jinJiPoint.ToString();
        }

        private void sysMinus_Click(object sender, EventArgs e)
        {
            if (sysNum > 0)
            {
                sysNum--;
                sysNumShow.Text = sysNum.ToString();
                jinJiPoint -= MQGS_VALUE;
                jinJiPointShow.Text = jinJiPoint.ToString();
            }
        }

        private void sysPlus_Click(object sender, EventArgs e)
        {
            sysNum++;
            sysNumShow.Text = sysNum.ToString();
            jinJiPoint += MQGS_VALUE;
            jinJiPointShow.Text = jinJiPoint.ToString();
        }

        private void ndMqgsMinus_Click(object sender, EventArgs e)
        {
            if (ndMqgsNum > 0)
            {
                ndMqgsNum--;
                ndMqgsNumShow.Text = ndMqgsNum.ToString();
                jinJiPoint -= ND_MQGS_VALUE;
                jinJiPointShow.Text = jinJiPoint.ToString();
            }
        }

        private void ndMqgsPlus_Click(object sender, EventArgs e)
        {
            ndMqgsNum++;
            ndMqgsNumShow.Text = ndMqgsNum.ToString();
            jinJiPoint += ND_MQGS_VALUE;
            jinJiPointShow.Text = jinJiPoint.ToString();
        }

        private void _4xy5Minus_Click(object sender, EventArgs e)
        {
            if (_4xy5Num > 0)
            {
                _4xy5Num--;
                _4xy5NumShow.Text = _4xy5Num.ToString();
                jinJiPoint -= _4_XY_5_VALUE;
                jinJiPointShow.Text = jinJiPoint.ToString();
            }
        }

        private void _4xy5Plus_Click(object sender, EventArgs e)
        {
            _4xy5Num++;
            _4xy5NumShow.Text = _4xy5Num.ToString();
            jinJiPoint += _4_XY_5_VALUE;
            jinJiPointShow.Text = jinJiPoint.ToString();
        }

        private void jrndMinus_Click(object sender, EventArgs e)
        {
            if (jrndNum > 0)
            {
                jrndNum--;
                jrndNumShow.Text = jrndNum.ToString();
                jinJiPoint -= JRND_VALUE;
                jinJiPointShow.Text = jinJiPoint.ToString();
            }
        }

        private void jrndPlus_Click(object sender, EventArgs e)
        {
            jrndNum++;
            jrndNumShow.Text = jrndNum.ToString();
            jinJiPoint += JRND_VALUE;
            jinJiPointShow.Text = jinJiPoint.ToString();
        }

        private void tzNddcMinus_Click(object sender, EventArgs e)
        {
            if (tzNddcNum > 0)
            {
                tzNddcNum--;
                tzNddcNumShow.Text = tzNddcNum.ToString();
                jinJiPoint -= TZ_NDDC_VALUE;
                jinJiPointShow.Text = jinJiPoint.ToString();
            }
        }

        private void tzNddcPlus_Click(object sender, EventArgs e)
        {
            tzNddcNum++;
            tzNddcNumShow.Text = tzNddcNum.ToString();
            jinJiPoint += TZ_NDDC_VALUE;
            jinJiPointShow.Text = jinJiPoint.ToString();
        }

        private void hhcdSx_CheckedChanged(object sender, EventArgs e)
        {
            if (sbdsd.Checked)
            {
                teShuPoint += SBDSD_VALUE;
                //sbdsd_jj.Enabled = true;
                teShuPointShow.Text = teShuPoint.ToString();
            }
            else if (!sbdsd.Checked)
            {
                teShuPoint -= SBDSD_VALUE;
                //sbdsd_jj.Checked = false;
                //sbdsd_jj.Enabled = false;
                teShuPointShow.Text = teShuPoint.ToString();
            }
        }

        private void sbdsd_jj_CheckedChanged(object sender, EventArgs e)
        {
            if (false)
            {
                teShuPoint += TS_JJ;
                teShuPointShow.Text = teShuPoint.ToString();
            }
            else if (!false)
            {
                teShuPoint -= TS_JJ;
                teShuPointShow.Text = teShuPoint.ToString();
            }
        }

        private void xhd_CheckedChanged(object sender, EventArgs e)
        {
            if (xhd.Checked)
            {
                teShuPoint += XHD_VALUE;
                xhd_jj.Enabled = true;
                teShuPointShow.Text = teShuPoint.ToString();
            }
            else if (!xhd.Checked)
            {
                teShuPoint -= XHD_VALUE;
                xhd_jj.Checked = false;
                xhd_jj.Enabled = false;
                teShuPointShow.Text = teShuPoint.ToString();
            }
        }

        private void xhd_jj_CheckedChanged(object sender, EventArgs e)
        {
            if (xhd_jj.Checked)
            {
                teShuPoint += TS_JJ;
                teShuPointShow.Text = teShuPoint.ToString();
            }
            else if (!xhd_jj.Checked)
            {
                teShuPoint -= TS_JJ;
                teShuPointShow.Text = teShuPoint.ToString();
            }
        }

        private void jxjs_CheckedChanged(object sender, EventArgs e)
        {
            if (jxjs.Checked)
            {
                teShuPoint += JXJS_VALUE;
                //jxjs_jj.Enabled = true;
                teShuPointShow.Text = teShuPoint.ToString();
            }
            else if (!jxjs.Checked)
            {
                teShuPoint -= JXJS_VALUE;
                //jxjs_jj.Checked = false;
                //jxjs_jj.Enabled = false;
                teShuPointShow.Text = teShuPoint.ToString();
            }
        }

        private void jxjs_jj_CheckedChanged(object sender, EventArgs e)
        {
            if (false)
            {
                teShuPoint += TS_JJ;
                teShuPointShow.Text = teShuPoint.ToString();
            }
            else if (!false)
            {
                teShuPoint -= TS_JJ;
                teShuPointShow.Text = teShuPoint.ToString();
            }
        }

        private void wjdbf_CheckedChanged(object sender, EventArgs e)
        {
            if (wjdbf.Checked)
            {
                teShuPoint += WJDBF_VALUE;
                wjdbf_jj.Enabled = true;
                teShuPointShow.Text = teShuPoint.ToString();
            }
            else if (!wjdbf.Checked)
            {
                teShuPoint -= WJDBF_VALUE;
                wjdbf_jj.Checked = false;
                wjdbf_jj.Enabled = false;
                teShuPointShow.Text = teShuPoint.ToString();
            }
        }

        private void wjdbf_jj_CheckedChanged(object sender, EventArgs e)
        {
            if (wjdbf_jj.Checked)
            {
                teShuPoint += TS_JJ;
                teShuPointShow.Text = teShuPoint.ToString();
            }
            else if (!wjdbf_jj.Checked)
            {
                teShuPoint -= TS_JJ;
                teShuPointShow.Text = teShuPoint.ToString();
            }
        }

        private void zccm_CheckedChanged(object sender, EventArgs e)
        {
            if (zccm.Checked)
            {
                teShuPoint += ZCCM_VALUE;
                zccm_jj.Enabled = true;
                teShuPointShow.Text = teShuPoint.ToString();
            }
            else if (!zccm.Checked)
            {
                teShuPoint -= ZCCM_VALUE;
                zccm_jj.Checked = false;
                zccm_jj.Enabled = false;
                teShuPointShow.Text = teShuPoint.ToString();
            }
        }

        private void zccm_jj_CheckedChanged(object sender, EventArgs e)
        {
            if (zccm_jj.Checked)
            {
                teShuPoint += TS_JJ;
                teShuPointShow.Text = teShuPoint.ToString();
            }
            else if (!zccm_jj.Checked)
            {
                teShuPoint -= TS_JJ;
                teShuPointShow.Text = teShuPoint.ToString();
            }
        }

        private void yxwmTg_CheckedChanged(object sender, EventArgs e)
        {
            if (ysgl.Checked)
            {
                yxwmNum = 0;
                yxwmNumShow.Text = yxwmNum.ToString();
                yxwmPoint = YSGL_VALUE;
                teShuPoint += YSGL_VALUE;
                teShuPointShow.Text = teShuPoint.ToString();
                //ysgl_jj.Enabled = true;
                //yxwmJs.Enabled = true;
                yxwmMinus.Enabled = true;
                yxwmNumShow.Enabled = true;
                yxwmPlus.Enabled = true;
                ysgl_wl.Enabled = true;
            }
            else if (!ysgl.Checked)
            {
                teShuPoint -= yxwmPoint;
                yxwmNum = 0;
                teShuPointShow.Text = teShuPoint.ToString();
                yxwmNumShow.Text = yxwmNum.ToString();
                yxwmPoint = 0;
                //ysgl_jj.Checked = false;
                //ysgl_jj.Enabled = false;
                yxwmJs.Enabled = false;
                yxwmMinus.Enabled = false;
                yxwmNumShow.Enabled = false;
                yxwmPlus.Enabled = false;
                ysgl.Checked = false;
                ysgl_wl.Checked = false;
                ysgl_wl.Enabled = false;
            }
            ysgl.Text = "鸭速公路" + "(" + yxwmPoint.ToString() + ")";
        }

        private void ysgl_jj_CheckedChanged(object sender, EventArgs e)
        {
            if (false)
            {
                teShuPoint -= yxwmPoint;
                yxwmPoint = YSGL_VALUE + YSGL_JJ_JS[yxwmNum];
                teShuPoint += yxwmPoint;
                ysgl_wl.Checked = false;
            }
            else if (!false)
            {
                if (yxwmNum > 3)
                {
                    yxwmNum = 3;
                    yxwmNumShow.Text = yxwmNum.ToString();
                }
                teShuPoint -= yxwmPoint;
                yxwmPoint = YSGL_VALUE + YSGL_JS[yxwmNum];
                teShuPoint += yxwmPoint;
            }
            ysgl.Text = "鸭速公路" + "(" + yxwmPoint.ToString() + ")";
            teShuPointShow.Text = teShuPoint.ToString();
        }

        private void yxwmMinus_Click(object sender, EventArgs e)
        {
            if (!false)
            {
                if (yxwmNum > 0)
                {
                    yxwmNum--;
                    yxwmNumShow.Text = yxwmNum.ToString();
                    teShuPoint -= yxwmPoint;
                    yxwmPoint = YSGL_VALUE + YSGL_JS[yxwmNum];
                    teShuPoint += yxwmPoint;
                    teShuPointShow.Text = teShuPoint.ToString();
                    ysgl.Text = "鸭速公路" + "(" + yxwmPoint.ToString() + ")";
                }
            }
            else if (false)
            {
                if (yxwmNum > 0)
                {
                    yxwmNum--;
                    yxwmNumShow.Text = yxwmNum.ToString();
                    teShuPoint -= yxwmPoint;
                    yxwmPoint = YSGL_VALUE + YSGL_JJ_JS[yxwmNum];
                    teShuPoint += yxwmPoint;
                    teShuPointShow.Text = teShuPoint.ToString();
                    ysgl.Text = "鸭速公路" + "(" + yxwmPoint.ToString() + ")";
                }
            }
        }

        private void yxwmPlus_Click(object sender, EventArgs e)
        {
            if (!false)
            {
                if (yxwmNum < 4)
                {
                    yxwmNum++;
                    yxwmNumShow.Text = yxwmNum.ToString();
                    teShuPoint -= yxwmPoint;
                    yxwmPoint = YSGL_VALUE + YSGL_JS[yxwmNum];
                    teShuPoint += yxwmPoint;
                    teShuPointShow.Text = teShuPoint.ToString();
                    ysgl.Text = "鸭速公路" + "(" + yxwmPoint.ToString() + ")";
                }
            }
            else if (false)
            {
                if (yxwmNum < 4)
                {
                    yxwmNum++;
                    yxwmNumShow.Text = yxwmNum.ToString();
                    teShuPoint -= yxwmPoint;
                    yxwmPoint = YSGL_VALUE + YSGL_JJ_JS[yxwmNum];
                    teShuPoint += yxwmPoint;
                    teShuPointShow.Text = teShuPoint.ToString();
                    ysgl.Text = "鸭速公路" + "(" + yxwmPoint.ToString() + ")";
                }
            }
        }

        private void ysgl_wl_CheckedChanged(object sender, EventArgs e)
        {
            if (!false)
            {
                if (ysgl_wl.Checked)
                {
                    yxwmNum = 3;
                    yxwmNumShow.Text = yxwmNum.ToString();
                    yxwmJs.Enabled = false;
                    yxwmMinus.Enabled = false;
                    yxwmNumShow.Enabled = false;
                    yxwmPlus.Enabled = false;
                    teShuPoint -= yxwmPoint;
                    yxwmPoint = YSGL_JS3_WL;
                    teShuPoint += yxwmPoint;
                    teShuPointShow.Text = teShuPoint.ToString();
                }
                else if (!ysgl_wl.Checked)
                {
                    if (ysgl.Checked)
                    {
                        yxwmJs.Enabled = true;
                        yxwmMinus.Enabled = true;
                        yxwmNumShow.Enabled = true;
                        yxwmPlus.Enabled = true;
                        teShuPoint -= yxwmPoint;
                        yxwmPoint = YSGL_VALUE + YSGL_JS[yxwmNum];
                        teShuPoint += yxwmPoint;
                        teShuPointShow.Text = teShuPoint.ToString();
                    }
                }
            }
            else if (true)
            {
                if (ysgl_wl.Checked)
                {
                    yxwmNum = 4;
                    yxwmNumShow.Text = yxwmNum.ToString();
                    yxwmJs.Enabled = false;
                    yxwmMinus.Enabled = false;
                    yxwmNumShow.Enabled = false;
                    yxwmPlus.Enabled = false;
                    teShuPoint -= yxwmPoint;
                    yxwmPoint = YSGL_JJ_JS4_WL;
                    teShuPoint += yxwmPoint;
                    teShuPointShow.Text = teShuPoint.ToString();
                }
                else if (!ysgl_wl.Checked)
                {
                    if (ysgl.Checked)
                    {
                        yxwmJs.Enabled = true;
                        yxwmMinus.Enabled = true;
                        yxwmNumShow.Enabled = true;
                        yxwmPlus.Enabled = true;
                        teShuPoint -= yxwmPoint;
                        yxwmPoint = YSGL_VALUE + YSGL_JJ_JS[yxwmNum];
                        teShuPoint += yxwmPoint;
                        teShuPointShow.Text = teShuPoint.ToString();
                    }
                }
            }
            ysgl.Text = "鸭速公路" + "(" + yxwmPoint.ToString() + ")";
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
                try
                {
                    cpNum = int.Parse(cpNumShow.Text);
                }
                catch { }
            }
        }

        private void bzNumShow_TextChanged(object sender, EventArgs e)
        {
            if (sxNumShow.Text == "")
            {
                sxNum = 0;
            }
            else
            {
                try
                {
                    sxNum = int.Parse(sxNumShow.Text);
                }
                catch { }
            }
        }

        private void jjsk_CheckedChanged(object sender, EventArgs e)
        {
            if (jjsk.Checked)
            {
                jjskPoint = JJSK_VALUE;
                jjsk_yg.Enabled = true;
                jjsk_nd.Enabled = true;
                jjsk_hl.Enabled = true;
                cy.Checked = false;
                cy.Enabled = false;
            }
            else if (!jjsk.Checked)
            {
                jjskPoint = 0;
                jjsk_yg.Checked = false;
                jjsk_yg.Enabled = false;
                jjsk_nd.Checked = false;
                jjsk_nd.Enabled = false;
                jjsk_hl.Checked = false;
                jjsk_hl.Enabled = false;
                cy.Enabled = true;
            }
            if (cy.Checked && sc.Checked)
            {
                lianDaPoint = JJ24_LIANDA;
            }
            else if (jjsk.Checked && sc.Checked)
            {
                lianDaPoint = JJ14_LIANDA;
            }
            else
            {
                jjskPoint = 0;
            }
            jjskPointTot = jjskPoint + jjskNdPoint + jjskHlPoint;
            cyPointTot = cyPoint + cyNdPoint + cyHlPoint;
            scPointTot = scPoint + scNdPoint + scHlPoint;
            jjPoint = jjskPointTot + cyPointTot + scPointTot + lianDaPoint;
            jjPointShow.Text = jjPoint.ToString();
        }

        private void jjsk_yg_CheckedChanged(object sender, EventArgs e)
        {
            if (jjsk_yg.Checked)
            {
                jjskYgPoint = JJSK_YG;
            }
            else if (!jjsk_yg.Checked)
            {
                jjskYgPoint = 0;
            }
            if (cy.Checked && sc.Checked)
            {
                lianDaPoint = JJ24_LIANDA;
            }
            else if (jjsk.Checked && sc.Checked)
            {
                lianDaPoint = JJ14_LIANDA;
            }
            else
            {
                jjskPoint = 0;
            }
            jjskPointTot = jjskPoint + jjskYgPoint + jjskNdPoint + jjskHlPoint;
            cyPointTot = cyPoint + cyNdPoint + cyHlPoint;
            scPointTot = scPoint + scNdPoint + scHlPoint;
            jjPoint = jjskPointTot + cyPointTot + scPointTot + lianDaPoint;
            jjPointShow.Text = jjPoint.ToString();
        }

        private void jjsk_nd_CheckedChanged(object sender, EventArgs e)
        {
            if (jjsk_nd.Checked)
            {
                jjskNdPoint = JJ_ND;
            }
            else if (!jjsk_nd.Checked)
            {
                jjskNdPoint = 0;
            }
            if (cy.Checked && sc.Checked)
            {
                lianDaPoint = JJ24_LIANDA;
            }
            else if (jjsk.Checked && sc.Checked)
            {
                lianDaPoint = JJ14_LIANDA;
            }
            else
            {
                jjskPoint = 0;
            }
            jjskPointTot = jjskPoint + jjskYgPoint + jjskNdPoint + jjskHlPoint;
            cyPointTot = cyPoint + cyNdPoint + cyHlPoint;
            scPointTot = scPoint + scNdPoint + scHlPoint;
            jjPoint = jjskPointTot + cyPointTot + scPointTot + lianDaPoint;
            jjPointShow.Text = jjPoint.ToString();
        }

        private void jjsk_hl_CheckedChanged(object sender, EventArgs e)
        {
            if (jjsk_hl.Checked)
            {
                jjskHlPoint = JJ_HL;
            }
            else if (!jjsk_hl.Checked)
            {
                jjskHlPoint = 0;
            }
            if (cy.Checked && sc.Checked)
            {
                lianDaPoint = JJ24_LIANDA;
            }
            else if (jjsk.Checked && sc.Checked)
            {
                lianDaPoint = JJ14_LIANDA;
            }
            else
            {
                jjskPoint = 0;
            }
            jjskPointTot = jjskPoint + jjskYgPoint + jjskNdPoint + jjskHlPoint;
            cyPointTot = cyPoint + cyNdPoint + cyHlPoint;
            scPointTot = scPoint + scNdPoint + scHlPoint;
            jjPoint = jjskPointTot + cyPointTot + scPointTot + lianDaPoint;
            jjPointShow.Text = jjPoint.ToString();
        }

        private void cy_CheckedChanged(object sender, EventArgs e)
        {
            if (cy.Checked)
            {
                cyPoint = CY_VALUE;
                cy_nd.Enabled = true;
                cy_hl.Enabled = true;
                jjsk.Checked = false;
                jjsk.Enabled = false;
            }
            else if (!cy.Checked)
            {
                cyPoint = 0;
                cy_nd.Checked = false;
                cy_nd.Enabled = false;
                cy_hl.Checked = false;
                cy_hl.Enabled = false;
                jjsk.Enabled = true;
            }
            if (cy.Checked && sc.Checked)
            {
                lianDaPoint = JJ24_LIANDA;
            }
            else if (jjsk.Checked && sc.Checked)
            {
                lianDaPoint = JJ14_LIANDA;
            }
            else
            {
                jjskPoint = 0;
            }
            jjskPointTot = jjskPoint + jjskYgPoint + jjskNdPoint + jjskHlPoint;
            cyPointTot = cyPoint + cyNdPoint + cyHlPoint;
            scPointTot = scPoint + scNdPoint + scHlPoint;
            jjPoint = jjskPointTot + cyPointTot + scPointTot + lianDaPoint;
            jjPointShow.Text = jjPoint.ToString();
        }

        private void cy_nd_CheckedChanged(object sender, EventArgs e)
        {
            if (cy_nd.Checked)
            {
                cyNdPoint = JJ_ND;
            }
            else if (!cy_nd.Checked)
            {
                cyNdPoint = 0;
            }
            if (cy.Checked && sc.Checked)
            {
                lianDaPoint = JJ24_LIANDA;
            }
            else if (jjsk.Checked && sc.Checked)
            {
                lianDaPoint = JJ14_LIANDA;
            }
            else
            {
                jjskPoint = 0;
            }
            jjskPointTot = jjskPoint + jjskYgPoint + jjskNdPoint + jjskHlPoint;
            cyPointTot = cyPoint + cyNdPoint + cyHlPoint;
            scPointTot = scPoint + scNdPoint + scHlPoint;
            jjPoint = jjskPointTot + cyPointTot + scPointTot + lianDaPoint;
            jjPointShow.Text = jjPoint.ToString();
        }

        private void cy_hl_CheckedChanged(object sender, EventArgs e)
        {
            if (cy_hl.Checked)
            {
                cyHlPoint = JJ_HL;
            }
            else if (!cy_hl.Checked)
            {
                cyHlPoint = 0;
            }
            if (cy.Checked && sc.Checked)
            {
                lianDaPoint = JJ24_LIANDA;
            }
            else if (jjsk.Checked && sc.Checked)
            {
                lianDaPoint = JJ14_LIANDA;
            }
            else
            {
                jjskPoint = 0;
            }
            jjskPointTot = jjskPoint + jjskYgPoint + jjskNdPoint + jjskHlPoint;
            cyPointTot = cyPoint + cyNdPoint + cyHlPoint;
            scPointTot = scPoint + scNdPoint + scHlPoint;
            jjPoint = jjskPointTot + cyPointTot + scPointTot + lianDaPoint;
            jjPointShow.Text = jjPoint.ToString();
        }

        private void sc_CheckedChanged(object sender, EventArgs e)
        {
            if (sc.Checked)
            {
                scPoint = SC_VALUE;
                sc_nd.Enabled = true;
                sc_hl.Enabled = true;
            }
            else if (!sc.Checked)
            {
                scPoint = 0;
                sc_nd.Checked = false;
                sc_nd.Enabled = false;
                sc_hl.Checked = false;
                sc_hl.Enabled = false;
            }
            if (cy.Checked && sc.Checked)
            {
                lianDaPoint = JJ24_LIANDA;
            }
            else if (jjsk.Checked && sc.Checked)
            {
                lianDaPoint = JJ14_LIANDA;
            }
            else
            {
                jjskPoint = 0;
            }
            jjskPointTot = jjskPoint + jjskYgPoint + jjskNdPoint + jjskHlPoint;
            cyPointTot = cyPoint + cyNdPoint + cyHlPoint;
            scPointTot = scPoint + scNdPoint + scHlPoint;
            jjPoint = jjskPointTot + cyPointTot + scPointTot + lianDaPoint;
            jjPointShow.Text = jjPoint.ToString();
        }

        private void sc_nd_CheckedChanged(object sender, EventArgs e)
        {
            if (sc_nd.Checked)
            {
                scNdPoint = JJ_DD_ND;
            }
            else if (!sc_nd.Checked)
            {
                scNdPoint = 0;
            }
            if (cy.Checked && sc.Checked)
            {
                lianDaPoint = JJ24_LIANDA;
            }
            else if (jjsk.Checked && sc.Checked)
            {
                lianDaPoint = JJ14_LIANDA;
            }
            else
            {
                jjskPoint = 0;
            }
            jjskPointTot = jjskPoint + jjskYgPoint + jjskNdPoint + jjskHlPoint;
            cyPointTot = cyPoint + cyNdPoint + cyHlPoint;
            scPointTot = scPoint + scNdPoint + scHlPoint;
            jjPoint = jjskPointTot + cyPointTot + scPointTot + lianDaPoint;
            jjPointShow.Text = jjPoint.ToString();
        }

        private void sc_hl_CheckedChanged(object sender, EventArgs e)
        {
            if (sc_hl.Checked)
            {
                scHlPoint = JJ_DD_HL;
            }
            else if (!sc_hl.Checked)
            {
                scHlPoint = 0;
            }
            if (cy.Checked && sc.Checked)
            {
                lianDaPoint = JJ24_LIANDA;
            }
            else if (jjsk.Checked && sc.Checked)
            {
                lianDaPoint = JJ14_LIANDA;
            }
            else
            {
                jjskPoint = 0;
            }
            jjskPointTot = jjskPoint + jjskYgPoint + jjskNdPoint + jjskHlPoint;
            cyPointTot = cyPoint + cyNdPoint + cyHlPoint;
            scPointTot = scPoint + scNdPoint + scHlPoint;
            jjPoint = jjskPointTot + cyPointTot + scPointTot + lianDaPoint;
            jjPointShow.Text = jjPoint.ToString();
        }

        private void fen_dui_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fen_dui.SelectedItem != null)
            {
                if (fen_dui.SelectedItem.ToString() == "魂灵护送分队" || fen_dui.SelectedItem.ToString() == "博闻广记分队")
                {
                    fdLabel.Text = "构思数量";
                    fdLabel.Visible = true;
                    fdNumShow.Visible = true;
                    fdMinus.Visible = true;
                    fdPlus.Visible = true;
                    fdNum = 0;
                    fdNumShow.Text = fdNum.ToString();
                }
                else if (fen_dui.SelectedItem.ToString() == "矛头分队" || fen_dui.SelectedItem.ToString() == "蓝图测绘分队")
                {
                    fdLabel.Text = "关卡数量";
                    fdLabel.Visible = true;
                    fdNumShow.Visible = true;
                    fdMinus.Visible = true;
                    fdPlus.Visible = true;
                    fdNum = 0;
                    fdNumShow.Text = fdNum.ToString();
                }
                else if (fen_dui.SelectedItem.ToString() == "高规格分队")
                {
                    fdLabel.Text = "五星数量";
                    fdLabel.Visible = true;
                    fdNumShow.Visible = true;
                    fdMinus.Visible = true;
                    fdPlus.Visible = true;
                    fdNum = 0;
                    fdNumShow.Text = fdNum.ToString();
                }
                else if (fen_dui.SelectedItem.ToString() == "堡垒战术分队")
                {
                    fdLabel.Text = "辅助数量";
                    fdLabel.Visible = true;
                    fdNumShow.Visible = true;
                    fdMinus.Visible = true;
                    fdPlus.Visible = true;
                    fdNum = 0;
                    fdNumShow.Text = fdNum.ToString();
                }
                else
                {
                    fdLabel.Visible = false;
                    fdNumShow.Visible = false;
                    fdMinus.Visible = false;
                    fdPlus.Visible = false;
                    fdNum = 0;
                    fdNumShow.Text = fdNum.ToString();
                }
            }
        }

        private void fdMinus_Click(object sender, EventArgs e)
        {
            if (fdNum > 0)
            {
                fdNum--;
                fdNumShow.Text = fdNum.ToString();
            }
        }

        private void fdMinus_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        private void fdMinus_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer2.Interval = 50;
            timer2.Enabled = true;
            timer1.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (fdNum > 0)
            {
                fdNum--;
                fdNumShow.Text = fdNum.ToString();
            }
        }

        private void fdPlus_Click(object sender, EventArgs e)
        {
            fdNum++;
            fdNumShow.Text = fdNum.ToString();
        }

        private void fdPlus_MouseDown(object sender, MouseEventArgs e)
        {
            timer3.Interval = 1000;
            timer3.Enabled = true;
        }

        private void fdPlus_MouseUp(object sender, MouseEventArgs e)
        {
            timer3.Enabled = false;
            timer4.Enabled = false;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer4.Interval = 50;
            timer4.Enabled = true;
            timer3.Enabled = false;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            fdNum++;
            fdNumShow.Text = fdNum.ToString();
        }

        private void xzPointShow_TextChanged(object sender, EventArgs e)
        {
            if (xzPointShow.Text == "")
            {
                xzPoint = 0;
            }
            else
            {
                try
                {
                    xzPoint = int.Parse(xzPointShow.Text);
                }
                catch { }
            }
        }

        private void ye_qian_TextChanged(object sender, EventArgs e)
        {
            if (ye_qian.Text == "")
            {
                yeQ = 0;
            }
            else
            {
                try
                {
                    yeQ = int.Parse(ye_qian.Text);
                }
                catch { }
            }
            qq_sum.Text = (yeQ - yeH).ToString();
        }

        private void ye_hou_TextChanged(object sender, EventArgs e)
        {
            if (ye_hou.Text == "")
            {
                yeH = 0;
            }
            else
            {
                try
                {
                    yeH = int.Parse(ye_hou.Text);
                }
                catch { }
            }
            qq_sum.Text = (yeQ - yeH).ToString();
        }

        public int calculate()
        {
            double tot;
            tot = Math.Ceiling(1.0 * xzcjMult * gdxzMult * (jsPoint + jinJiPoint + teShuPoint + f3YiGe + ycPoint + jjPoint + lzPoint + xzPoint + pbPoint + ansjmPoint));
            //  if (fen_dui.SelectedItem.ToString() == "魂灵护送分队" || fen_dui.SelectedItem.ToString() == "博闻广记分队")
            //  {
            //      tot += fdNum * GX;
            //  }
            //  else if (fen_dui.SelectedItem.ToString() == "矛头分队")
            //  {
            //      tot += fdNum * MT;
            //  }
            //  else if (fen_dui.SelectedItem.ToString() == "高规格分队")
            //  {
            //      tot += fdNum * GGG;
            //  }
            return (int)tot;
        }
        private void act_Click(object sender, EventArgs e)
        {
            if (fen_dui.SelectedItem == null)
            {
                DialogResult tmp = System.Windows.Forms.MessageBox.Show(
               "请选择分队！",
               "未选择分队", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                total = calculate();
                totalShow.Text = total.ToString();
                DialogResult Warning = System.Windows.Forms.MessageBox.Show(
                    "下面计数器只用作辅助记忆，请稍后将其记录。来自分队的增益分需全队打完后结算！\n无特殊情况不需要填修正分！",
                    "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (total >= 3500)
                {
                    totalShow.Text += "!";
                }
                totalShow.Visible = true;
            }
        }

        private void jsPointShow_TextChanged(object sender, EventArgs e)
        {
            if (jsPointShow.Text == "")
            {
                jsPoint = 0;
            }
            try
            {
                jsPoint = int.Parse(jsPointShow.Text);
            }
            catch { }
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

        private void dhsForm_Load(object sender, EventArgs e)
        {

        }

        private void tdfs_Click(object sender, EventArgs e)
        {

        }

        private void pb_CheckedChanged(object sender, EventArgs e)
        {
            if (!pb.Checked)
            {
                pbPoint = 0;
            }
            else if (pb.Checked)
            {
                pbPoint = 30;
            }
        }

        private void xzcj_CheckedChanged(object sender, EventArgs e)
        {
            if (!xzcj.Checked)
            {
                xzcjMult = 1;
            }
            else if (xzcj.Checked)
            {
                xzcjMult = 0.6;
            }
        }

        private void ansjm_CheckedChanged(object sender, EventArgs e)
        {
            if (!ansjm.Checked)
            {
                ansjmPoint = 0;
            }
            else if (ansjm.Checked)
            {
                ansjmPoint = 60;
            }
        }

        private void gdxz_CheckedChanged(object sender, EventArgs e)
        {
            if (!gdxz.Checked)
            {
                gdxzMult = 1;
            }
            else if (gdxz.Checked)
            {
                gdxzMult = 1.1;
            }
        }
    }
}
