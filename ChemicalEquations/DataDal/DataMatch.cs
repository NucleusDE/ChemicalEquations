using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data;
using System.Collections;

namespace DataDal
{
    public class DataMatch
    {
        static SolutionSet_Output output = new SolutionSet_Output();
        static Solution_Output last = new Solution_Output();

        static public SolutionSet_Output Match(AllData_IN data, ArrayList alLast)
        {
            //ArrayList alTemp = new ArrayList();

            //foreach (MyEnumType type in Enum.GetValues(typeof(MyEnumType)))
            //{
            //    // TODO: 遍历操作
            //}
            //foreach (string name in Enum.GetNames(typeof(MyEnumType)))
            //{
            //    // TODO:遍历操作
            //}

            //匹配一个化学式
            ArrayList alResult = new ArrayList();
            data.IsLoaded = true;   //标记已读

            //反应物匹配(遍历用户输入的化学方程式里面所有反应物)
            for (int iData = 0; iData < data.Data.Reactent.Count; iData++)
            {
                //遍历反应物数组
                ArrayList alReactentTemp = (ArrayList)data.Data.Reactent[iData];
                for (int iAlReactentTemp = 0; iAlReactentTemp < alReactentTemp.Count; iAlReactentTemp++)
                {
                    //获取单个元素包
                    ItemPack_Material mReactentTemp = (ItemPack_Material)alReactentTemp[iAlReactentTemp];
                    if (mReactentTemp.IsKnown)
                    {        //若已知此元素，遍历匹配
                        if (alResult.Count == 0)     //若为空，则大面积匹配
                        {
                            for (int iData_AllEquations = 0; iData_AllEquations < DefaultEquations.AllEquations.Count; iData_AllEquations++)
                            {
                                //单个化学方程式反应物元素拆箱                               
                                Equation eqTemp = (Equation)DefaultEquations.AllEquations[iData_AllEquations];
                                for (int iEqTemp = 0; iEqTemp < eqTemp.Reactants.Count; iEqTemp++)
                                {
                                    //遍历并进行第一次匹配
                                    if ((Materials)eqTemp.Reactants[iEqTemp] == mReactentTemp.Item)
                                    {
                                        alResult.Add(eqTemp);
                                        break;

                                    }
                                }
                            }
                        }
                        else   //若不为空，则遍历已第一次匹配
                        {
                            ArrayList alResultTempOverWriteTemp = new ArrayList();
                            for (int iAlResultTempOverWrite = 0; iAlResultTempOverWrite < alResult.Count; iAlResultTempOverWrite++)
                            {
                                //单个化学方程式反应物元素拆箱                               
                                Equation eqTemp = (Equation)alResult[iAlResultTempOverWrite];
                                for (int iEqTemp = 0; iEqTemp < eqTemp.Reactants.Count; iEqTemp++)
                                {
                                    //遍历是否与之前匹配出来的其他元素匹配
                                    if ((Materials)eqTemp.Reactants[iEqTemp] == mReactentTemp.Item)
                                        alResultTempOverWriteTemp.Add(eqTemp);
                                }
                            }
                            alResult = alResultTempOverWriteTemp;
                        }
                    }
                    else                                   //若未知
                    {

                    }
                }

            }

            //条件匹配
            for (int iData = 0; iData < data.Data.Conditions.Count; iData++)
            {
                ArrayList alConditionsTemp = (ArrayList)data.Data.Conditions[iData];
                //遍历所有条件获取单个进行匹配
                for (int iAlConditionsTemp = 0; iAlConditionsTemp < alConditionsTemp.Count; iAlConditionsTemp++)
                {
                    ItemPack_Condition cConditions = (ItemPack_Condition)alConditionsTemp[iAlConditionsTemp];
                    if (cConditions.IsKnown)  //是否为已知条件
                    {
                        //为已知条件
                        if (alResult.Count == 0)
                        {//若为空项
                            for (int iConditions_Equations = 0; iConditions_Equations < DefaultEquations.AllEquations.Count; iConditions_Equations++)
                            {
                                Equation equ = (Equation)DefaultEquations.AllEquations[iConditions_Equations];
                                for (int iEquConditions = 0; iEquConditions < equ.Conditions.Count; iEquConditions++)
                                {
                                    if ((Conditions)equ.Conditions[iEquConditions] == cConditions.Item)
                                    {
                                        alResult.Add(equ);
                                        break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            //不为空项
                            ArrayList alResultTempOverWriteTemp = new ArrayList();
                            for (int iAlResultTempOverWrite = 0; iAlResultTempOverWrite < alResult.Count; iAlResultTempOverWrite++)
                            {
                                //单个化学方程式反应物元素拆箱                               
                                Equation eqTemp = (Equation)alResult[iAlResultTempOverWrite];
                                for (int iEqTemp = 0; iEqTemp < eqTemp.Reactants.Count; iEqTemp++)
                                {
                                    //遍历是否与之前匹配出来的其他元素匹配
                                    if ((Conditions)eqTemp.Reactants[iEqTemp] ==cConditions.Item)
                                        alResultTempOverWriteTemp.Add(eqTemp);
                                }
                            }
                            alResult = alResultTempOverWriteTemp;
                        }
                    }
                    else
                    {
                        //不为已知条件
                    }
                }
            }

            //所有匹配结束
            //开始检验下一个节点的正确性

            //开始递归调用
            ArrayList alNext = data.NodeNext;

            for (int iAlNext = 0; iAlNext < alNext.Count; iAlNext++)
            {
                AllData_IN dataNext = (AllData_IN)alNext[iAlNext];   //取出用户定义下一节点的数据
                if (data == null)
                    return;

                for (int iDataNext = 0; iDataNext < dataNext.Data.Reactent.Count; iDataNext++)
                {
                    Materials mat = (Materials)dataNext.Data.Reactent[iDataNext];
                    //与下一个节点匹配
                    for (int iAlResult = 0; iAlResult < alResult.Count; iAlResult++)
                    {
                        AllData_IN dataMatchedEquations = new AllData_IN();   //下一个节点准确数据
                        bool isMatched = false;

                        Equation equ = (Equation)alResult[iAlResult];
                        for (int iEqu_Products = 0; iEqu_Products < equ.Prodcts.Count; iEqu_Products++)
                        {
                            if ((Materials)equ.Prodcts[iEqu_Products] == mat)
                            {
                                //是否存在相同元素
                                dataMatchedEquations.Data.Reactent = dataNext.Data.Reactent;
                                dataMatchedEquations.Data.Conditions = dataNext.Data.Conditions;
                                isMatched = true;
                            }
                        }
                        if (!isMatched)
                            return output;      //匹配失败

                        //存储此节点数据,并判定是否已读（避免回溯）
                        last.Solutions.Add(equ);
                        if (dataNext.IsLoaded == true)
                            return output;

                        Match(dataMatchedEquations, last.Solutions);

                       