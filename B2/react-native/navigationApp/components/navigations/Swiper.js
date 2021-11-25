import React from "react";
import { View } from 'react-native';
import { createMaterialTopTabNavigator } from '@react-navigation/material-top-tabs';
import Test1 from "../../views/Test1";
import Test2 from "../../views/Test2";
import Test3 from "../../views/Test3";

const Tab = createMaterialTopTabNavigator();

export default class Swiper extends React.Component {

    constructor(props) {
        super(props);
    }

    render() {

        return (
            <View style={{flex:1}}>
                <Tab.Navigator>
                    <Tab.Screen
                        name="Test 1"
                        children={() => <Test1/>}
                    />
                    <Tab.Screen
                        name="Test 2"
                        children={() => <Test2/>}
                    />
                    <Tab.Screen
                        name="Test 3"
                        children={() => <Test3/>}
                    />
                </Tab.Navigator>
            </View>
        );
    }
}