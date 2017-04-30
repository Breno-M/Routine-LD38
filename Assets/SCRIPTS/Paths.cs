using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paths
{

    public List<int> GetPath(int wpA, int wpB, bool going)
    {
        List<int> paths = new List<int>();

        //CHAR-WP0
        if ((wpA == 102 && wpB == 104) || (wpA == 106 && wpB == 104))
        {
            int[] n = { 41, 42, 135, 43, 3, 55, 54, 136, 48, 137, 130, 30, 31, 104 };
            int[] n2 = { 31, 30, 130, 137, 48, 136, 54, 55, 3, 43, 135, 42, 41, 102 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //CHAR-WP1
        else if ((wpA == 102 && wpB == 106) || (wpA == 106 && wpB == 102))
        {
            int[] n = { 41, 42, 135, 43, 3, 2, 1, 0, 27, 26, 25, 121, 24, 23, 106 };
            int[] n2 = { 23, 24, 121, 25, 26, 27, 0, 1, 2, 3, 43, 135, 42, 41, 102 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //CHAR-WP2 !
        else if ((wpA == 102 && wpB == 103) || (wpA == 103 && wpB == 102))
        {
            int[] n = { 40, 141, 39, 38, 37, 127, 103 };
            int[] n2 = { 127, 37, 38, 39, 141, 40, 102 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //CHAR-WP3
        else if ((wpA == 102 && wpB == 107) || (wpA == 107 && wpB == 102))
        {
            int[] n = { 41, 152, 59, 107 };
            int[] n2 = { 59, 152, 41, 102 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //CHAR-WP4
        else if ((wpA == 102 && wpB == 105) || (wpA == 105 && wpB == 102))
        {
            int[] n = { 41, 152, 59, 5, 101, 6, 7, 105 };
            int[] n2 = { 7, 6, 101, 5, 59, 152, 41, 102};

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //CHAR-WP5
        else if ((wpA == 102 && wpB == 172) || (wpA == 172 && wpB == 102))
        {
            int[] n = { 41, 152, 59, 5, 85, 94, 86, 87, 172 };
            int[] n2 = { 87, 86, 94, 85, 5, 59, 152, 41, 102 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //CHAR-WP6
        else if ((wpA == 102 && wpB == 173) || (wpA == 173 && wpB == 102))
        {
            int[] n = { 40, 141, 39, 64, 63, 173 };
            int[] n2 = { 63, 64, 39, 141, 40, 102 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //CHAR-WP7
        else if ((wpA == 102 && wpB == 174) || (wpA == 174 && wpB == 102))
        {
            int[] n = { 40, 141, 39, 38, 37, 73, 74, 75, 120, 115, 174 };
            int[] n2 = { 115, 120, 75, 74, 73, 37, 38, 39, 141, 40, 102 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //CHAR-WP8
        else if ((wpA == 102 && wpB == 175) || (wpA == 175 && wpB == 102))
        {
            int[] n = { 41, 152, 59, 5, 85, 94, 86, 87, 175 };
            int[] n2 = { 87, 86, 94, 85, 5, 59, 152, 41, 102 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //CHAR-WP9
        else if ((wpA == 102 && wpB == 176) || (wpA == 176 && wpB == 102))
        {
            int[] n = { 41, 42, 135, 43, 3, 55, 176 };
            int[] n2 = { 55, 3, 43, 135, 42, 41, 102 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //CHAR-BD0
        else if ((wpA == 102 && wpB == 108) || (wpA == 108 && wpB == 102))
        {
            int[] n = { 41, 152, 59, 5, 101, 88, 89, 108 };
            int[] n2 = { 89, 88, 101, 5, 59, 152, 41, 102 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //CHAR-BD1
        else if ((wpA == 102 && wpB == 99) || (wpA == 99 && wpB == 102))
        {
            int[] n = { 41, 152, 59, 107, 60, 61, 159, 99, 160 };
            int[] n2 = { 99, 159, 61, 60, 107, 59, 152, 41, 102 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //CHAR-BD2
        else if ((wpA == 102 && wpB == 109) || (wpA == 109 && wpB == 102))
        {
            int[] n = { 40, 141, 39, 38, 134, 72, 109 };
            int[] n2 = { 72, 134, 38, 39, 141, 40, 102 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //CHAR-BD3
        else if ((wpA == 102 && wpB == 77) || (wpA == 77 && wpB == 102))
        {
            int[] n = { 40, 141, 39, 38, 37, 127, 103, 36, 77 };
            int[] n2 = { 36, 103, 127, 37, 38, 39, 141, 40, 102 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //CHAR-BD4
        else if ((wpA == 102 && wpB == 110) || (wpA == 110 && wpB == 102))
        {
            int[] n = { 41, 42, 140, 58, 143, 4, 56, 149, 57, 53, 110 };
            int[] n2 = { 53, 57, 149, 56, 4, 143, 58, 140, 42, 41, 102 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //CHAR-BD5
        else if ((wpA == 102 && wpB == 111) || (wpA == 111 && wpB == 102))
        {
            int[] n = { 41, 42, 135, 43, 3, 55, 54, 136, 48, 137, 130, 30, 31, 104, 32, 21, 111 };
            int[] n2 = { 21, 32, 104, 31, 30, 130, 137, 48, 136, 54, 55, 3, 43, 135, 42, 41, 102 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //CHAR-BD6
        else if ((wpA == 102 && wpB == 81) || (wpA == 81 && wpB == 102))
        {
            int[] n = { 41, 42, 135, 43, 3, 2, 1, 81 };
            int[] n2 = { 1, 2, 3, 43, 135, 42, 41, 102 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //CHAR-BD7
        else if ((wpA == 102 && wpB == 177) || (wpA == 177 && wpB == 102))
        {
            int[] n = { 41, 42, 135, 43, 3, 55, 176, 54, 136, 48, 137, 130, 30, 31, 104, 32, 138, 177 };
            int[] n2 = { 138, 32, 104, 31, 30, 130, 137, 48, 136, 54, 176, 55, 3, 43, 135, 42, 41, 102 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //CHAR-BD8
        else if ((wpA == 102 && wpB == 178) || (wpA == 178 && wpB == 102))
        {
            int[] n = { 41, 152, 59, 5, 85, 94, 86, 87, 175, 18, 178 };
            int[] n2 = { 18, 175, 87, 86, 94, 85, 5, 59, 152, 41, 102 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //CHAR-BD9
        else if ((wpA == 102 && wpB == 93) || (wpA == 93 && wpB == 102))
        {
            int[] n = { 41, 152, 59, 5, 85, 94, 86, 87, 172, 91, 162, 92, 93 };
            int[] n2 = { 92, 162, 91, 172, 87, 86, 94, 85, 5, 59, 152, 41, 102 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////
        //FER-WP0 !
        else if ((wpA == 29 && wpB == 104) || (wpA == 104 && wpB == 29))
        {
            int[] n = { 126, 128, 30, 31, 104 };
            int[] n2 = { 31, 30, 128, 126, 29 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //FER-WP1
        else if ((wpA == 29 && wpB == 106) || (wpA == 106 && wpB == 29))
        {
            int[] n = { 123, 28, 27, 26, 25, 121, 24, 23, 106};
            int[] n2 = { 23, 24, 121, 25, 26, 27, 28, 123, 29 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //FER-WP2
        else if ((wpA == 29 && wpB == 103) || (wpA == 103 && wpB == 29))
        {
            int[] n = { 123, 28, 27, 0, 1, 78, 36, 103 };
            int[] n2 = { 36, 78, 1, 0, 27, 28, 123, 29 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //FER-WP3
        else if ((wpA == 29 && wpB == 107) || (wpA == 107 && wpB == 29))
        {
            int[] n = { 126, 128, 30, 130, 137, 48, 144, 145, 49, 153, 85, 5, 59, 107};
            int[] n2 = { 59, 5, 85, 153, 49, 145, 144, 48, 137, 130, 30, 128, 126, 29 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //FER-WP4
        else if ((wpA == 29 && wpB == 105) || (wpA == 105 && wpB == 29))
        {
            int[] n = { 126, 128, 30, 130, 137, 48, 144, 145, 49, 153, 85, 88, 101, 6, 7, 105 };
            int[] n2 = { 7, 6, 101, 88, 85, 153, 49, 145, 144, 48, 137, 130, 30, 128, 126, 29 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //FER-WP5
        else if ((wpA == 29 && wpB == 172) || (wpA == 172 && wpB == 29))
        {
            int[] n = { 126, 128, 30, 31, 139, 52, 148, 154, 86, 87, 172 };
            int[] n2 = { 87, 86, 154, 148, 52, 139, 31, 30, 128, 126, 29 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //FER-WP6
        else if ((wpA == 29 && wpB == 173) || (wpA == 173 && wpB == 29))
        {
            int[] n = { 126, 128, 30, 130, 137, 48, 136, 54, 55, 3, 43, 135, 42, 41, 102, 40, 141, 39, 64, 63, 173 };
            int[] n2 = { 63, 64, 39, 141, 40, 102, 41, 42, 135, 43, 3, 55, 54, 136, 48, 137, 130, 30, 128, 126, 29 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //FER-WP7
        else if ((wpA == 29 && wpB == 174) || (wpA == 174 && wpB == 29))
        {
            int[] n = { 123, 28, 27, 0, 1, 78, 36, 77, 76, 75, 120, 115, 174 };
            int[] n2 = { 115, 120, 75, 76, 77, 36, 78, 1, 0, 27, 28, 123, 29 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //FER-WP8
        else if ((wpA == 29 && wpB == 175) || (wpA == 175 && wpB == 29))
        {
            int[] n = { 126, 128, 30, 31, 139, 52, 148, 154, 86, 87, 175 };
            int[] n2 = { 87, 86, 154, 148, 52, 139, 31, 30, 128, 126, 29 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //FER-WP9
        else if ((wpA == 29 && wpB == 176) || (wpA == 176 && wpB == 29))
        {
            int[] n = { 126, 128, 30, 130, 137, 48, 136, 54, 176 };
            int[] n2 = { 54, 136, 48, 137, 130, 30, 128, 126, 29 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //FER-BD0
        else if ((wpA == 29 && wpB == 108) || (wpA == 108 && wpB == 29))
        {
            int[] n = { 126, 128, 30, 130, 137, 48, 144, 145, 49, 153, 85, 88, 89, 108 };
            int[] n2 = { 89, 88, 85, 153, 49, 145, 144, 48, 137, 130, 30, 128, 126, 29 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //FER-BD1
        else if ((wpA == 29 && wpB == 99) || (wpA == 99 && wpB == 29))
        {
            int[] n = { 126, 128, 30, 130, 137, 48, 144, 145, 49, 153, 85, 5, 59, 107, 60, 61, 159, 99, 160};
            int[] n2 = { 99, 159, 61, 60, 107, 59, 5, 85, 153, 49, 145, 144, 48, 137, 130, 30, 128, 126, 29 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //FER-BD2
        else if ((wpA == 29 && wpB == 109) || (wpA == 109 && wpB == 29))
        {
            int[] n = { 126, 128, 30, 130, 137, 48, 136, 54, 55, 3, 43, 131, 44, 45, 132, 133, 37, 38, 134, 72, 109 };
            int[] n2 = { 72, 134, 38, 37, 133, 132, 45, 44, 131, 43, 3, 55, 54, 136, 48, 137, 130, 30, 128, 126, 29 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //FER-BD3
        else if ((wpA == 29 && wpB == 77) || (wpA == 77 && wpB == 29))
        {
            int[] n = { 123, 28, 27, 0, 1, 78, 36, 77 };
            int[] n2 = { 36, 78, 1, 0, 27, 28, 123, 29 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //FER-BD4
        else if ((wpA == 29 && wpB == 110) || (wpA == 110 && wpB == 29))
        {
            int[] n = { 126, 128, 30, 130, 137, 48, 144, 145, 49, 110 };
            int[] n2 = { 49, 145, 144, 48, 137, 130, 30, 128, 126, 29 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //FER-BD5
        else if ((wpA == 29 && wpB == 111) || (wpA == 111 && wpB == 29))
        {
            int[] n = { 126, 128, 30, 31, 104, 32, 21, 111 };
            int[] n2 = { 21, 32, 104, 31, 30, 128, 126, 29 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //FER-BD6
        else if ((wpA == 29 && wpB == 81) || (wpA == 81 && wpB == 29))
        {
            int[] n = { 123, 28, 27, 0, 1, 81 };
            int[] n2 = { 1, 0, 27, 28, 123, 29 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //FER-BD7
        else if ((wpA == 29 && wpB == 177) || (wpA == 177 && wpB == 29))
        {
            int[] n = { 126, 128, 30, 31, 104, 32, 138, 177 };
            int[] n2 = { 138, 32, 104, 31, 30, 128, 126, 29 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //FER-BD8
        else if ((wpA == 29 && wpB == 178) || (wpA == 178 && wpB == 29))
        {
            int[] n = { 126, 128, 30, 31, 104, 32, 138, 177, 82, 146, 147, 83, 84, 19, 18, 178 };
            int[] n2 = { 18, 19, 84, 83, 147, 146, 82, 177, 138, 32, 104, 31, 30, 128, 126, 29 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //FER-BD9
        else if ((wpA == 29 && wpB == 93) || (wpA == 93 && wpB == 29))
        {
            int[] n = { 126, 128, 30, 31, 139, 52, 148, 154, 86, 87, 172, 91, 162, 92, 93 };
            int[] n2 = { 92, 162, 91, 172, 87, 86, 154, 148, 52, 139, 31, 30, 128, 126, 29 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////
        //ALE-WP0
        else if ((wpA == 11 && wpB == 104) || (wpA == 104 && wpB == 11))
        {
            int[] n = { 164, 10, 94, 86, 154, 148, 52, 139, 31, 104 };
            int[] n2 = { 31, 139, 52, 148, 154, 86, 94, 10, 164, 11 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //ALE-WP1
        else if ((wpA == 11 && wpB == 106) || (wpA == 106 && wpB == 11))
        {
            int[] n = { 164, 10, 94, 86, 154, 148, 52, 139, 31, 104, 32, 129, 33, 124, 23, 106 };
            int[] n2 = { 23, 124, 33, 129, 32, 104, 31, 139, 52, 148, 154, 86, 94, 10, 164, 11 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //ALE-WP2
        else if ((wpA == 11 && wpB == 103) || (wpA == 103 && wpB == 11))
        {
            int[] n = { 164, 10, 9, 171, 165, 163, 8, 105, 7, 6, 101, 5, 4, 3, 2, 1, 78, 36, 103 };
            int[] n2 = { 36, 78, 1, 2, 3, 4, 5, 101, 6, 7, 105, 8, 163, 165, 171, 9, 10, 164, 11 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //ALE-WP3
        else if ((wpA == 11 && wpB == 107) || (wpA == 107 && wpB == 11))
        {
            int[] n = { 164, 10, 9, 171, 165, 163, 8, 105, 7, 6, 101, 5, 59, 107 };
            int[] n2 = { 59, 5, 101, 6, 7, 105, 8, 163, 165, 171, 9, 10, 164, 11 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //ALE-WP4 !
        else if ((wpA == 11 && wpB == 105) || (wpA == 105 && wpB == 11))
        {
            int[] n = { 164, 10, 9, 171, 165, 163, 8, 105 };
            int[] n2 = { 8, 163, 165, 171, 9, 10, 164, 11 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //ALE-WP5 !
        else if ((wpA == 11 && wpB == 172) || (wpA == 172 && wpB == 11))
        {
            int[] n = { 169, 12, 168, 13, 167, 91, 172 };
            int[] n2 = { 91, 167, 13, 168, 12, 169, 11 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //ALE-WP6
        else if ((wpA == 11 && wpB == 173) || (wpA == 173 && wpB == 11))
        {
            int[] n = { 164, 10, 9, 171, 165, 163, 8, 105, 7, 6, 101, 5, 59, 107, 60, 61, 62, 63, 173 };
            int[] n2 = { 63, 62, 61, 60, 107, 59, 5, 101, 6, 7, 105, 8, 163, 165, 171, 9, 10, 164, 11 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //ALE-WP7
        else if ((wpA == 11 && wpB == 174) || (wpA == 174 && wpB == 11))
        {
            int[] n = { 164, 10, 94, 85, 5, 4, 3, 43, 131, 44, 45, 132, 133, 37, 73, 74, 75, 120, 115, 174 };
            int[] n2 = { 115, 120, 75, 74, 73, 37, 133, 132, 45, 44, 131, 43, 3, 4, 5, 85, 94, 10, 164, 11 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //ALE-WP8
        else if ((wpA == 11 && wpB == 175) || (wpA == 175 && wpB == 11))
        {
            int[] n = { 169, 12, 168, 13, 167, 91, 172, 87, 175 };
            int[] n2 = { 87, 172, 91, 167, 13, 168, 12, 169, 11 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //ALE-WP9
        else if ((wpA == 11 && wpB == 176) || (wpA == 176 && wpB == 11))
        {
            int[] n = { 164, 10, 94, 85, 153, 49, 110, 53, 54, 176 };
            int[] n2 = { 54, 53, 110, 49, 153, 85, 94, 10, 164, 11 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //ALE-BD0
        else if ((wpA == 11 && wpB == 108) || (wpA == 108 && wpB == 11))
        {
            int[] n = { 164, 10, 9, 171, 90, 108 };
            int[] n2 = { 90, 171, 9, 10, 164, 11 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //ALE-BD1
        else if ((wpA == 11 && wpB == 99) || (wpA == 99 && wpB == 11))
        {
            int[] n = { 164, 10, 9, 171, 165, 163, 8, 105, 7, 6, 97, 98, 161, 160 };
            int[] n2 = { 161, 98, 97, 6, 7, 105, 8, 163, 165, 171, 9, 10, 164, 11 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //ALE-BD2
        else if ((wpA == 11 && wpB == 109) || (wpA == 109 && wpB == 11))
        {
            int[] n = { 164, 10, 9, 171, 165, 163, 8, 105, 7, 6, 101, 5, 4, 3, 43, 131, 44, 45, 132, 133, 37, 38, 134, 72, 109 };
            int[] n2 = { 72, 134, 38, 37, 133, 132, 45, 44, 131, 43, 3, 4, 5, 101, 6, 7, 105, 8, 163, 165, 171, 9, 10, 164, 11 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //ALE-BD3
        else if ((wpA == 11 && wpB == 77) || (wpA == 77 && wpB == 11))
        {
            int[] n = { 164, 10, 9, 171, 165, 163, 8, 105, 7, 6, 101, 5, 4, 3, 2, 1, 78, 36, 77 };
            int[] n2 = { 36, 78, 1, 2, 3, 4, 5, 101, 6, 7, 105, 8, 163, 165, 171, 9, 10, 164, 11 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //ALE-BD4
        else if ((wpA == 11 && wpB == 110) || (wpA == 110 && wpB == 11))
        {
            int[] n = { 164, 10, 9, 171, 90, 108, 89, 88, 85, 153, 49, 110 };
            int[] n2 = { 49, 153, 85, 88, 89, 108, 90, 171, 9, 10, 164, 11 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //ALE-BD5
        else if ((wpA == 11 && wpB == 111) || (wpA == 111 && wpB == 11))
        {
            int[] n = { 169, 12, 168, 13, 167, 91, 87, 86, 154, 148, 52, 139, 31, 104, 32, 21, 111};
            int[] n2 = { 21, 32, 104, 31, 139, 52, 148, 154, 86, 87, 91, 167, 13, 168, 12, 169, 11};

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //ALE-BD6
        else if ((wpA == 11 && wpB == 81) || (wpA == 81 && wpB == 11))
        {
            int[] n = { 164, 10, 94, 85, 5, 4, 3, 2, 1, 81 };
            int[] n2 = { 1, 2, 3, 4, 5, 85, 94, 10, 164, 11 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //ALE-BD7
        else if ((wpA == 11 && wpB == 177) || (wpA == 177 && wpB == 11))
        {
            int[] n = { 164, 10, 94, 86, 154, 148, 52, 139, 31, 104, 32, 138, 177 };
            int[] n2 = { 138, 32, 104, 31, 139, 52, 148, 154, 86, 94, 10, 164, 11 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //ALE-BD8
        else if ((wpA == 11 && wpB == 178) || (wpA == 178 && wpB == 11))
        {
            int[] n = { 169, 12, 168, 13, 167, 91, 172, 87, 175, 18, 178 };
            int[] n2 = { 18, 175, 87, 172, 91, 167, 13, 168, 12, 169, 11 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }
        //ALE-BD9
        else if ((wpA == 11 && wpB == 93) || (wpA == 93 && wpB == 11))
        {
            int[] n = { 169, 12, 168, 13, 167, 93 };
            int[] n2 = { 167, 13, 168, 12, 169, 11 };

            if (going)
                paths.AddRange(n);
            else
                paths.AddRange(n2);
        }

        return paths;
    }

}
