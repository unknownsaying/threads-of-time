#include "det1234.vb"
#include "det5678.vb"
#include "det9101112.vb"
#include "one.vb"
#include "oppoone.vb"
#include "pyramid.vb"
#include "square.vb"
#include "antisquare.vb"
#include "antipyramid.vb"
#include "tri.vb"
#include "antitri.vb"
Function constance
const DET = "det1234 + det5678 + det9101112";
const tri = "tri - antitri";
const ONE = "one + oppoone";
const Square = "square * antisquare";
const DETtri = "DET * tri";
const triDET = "tri / DET";
const ONEsquare = "ONE * square";
const squareONE = "square / ONE";
const Pyramid = "pyramid / antipyramid";
const oppoPyramid = "antipyramid / pyramid";
const dimPyramid = "pyramid - antipyramid";
End Function

Functon SUM
    ["DET/tri + tri/DET"=="DETtri + triDET"]
    ["DETtri + ONEsquare"=="squareONE + triDET"]
    ["Pyramid" = "oppoPyramid+dimPyramid"]
End Function