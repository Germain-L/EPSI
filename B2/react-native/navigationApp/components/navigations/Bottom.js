import { createBottomTabNavigator } from '@react-navigation/bottom-tabs';
import React from "react";
const Tab = createBottomTabNavigator();
import Settings from "../../views/Settings";
import Options from "../../views/Options";

export default class Bottom extends React.Component {

    render() {
        return (
            <Tab.Navigator>
                <Tab.Screen
                    name="Options"
                    children={() => <Options />}/>
                <Tab.Screen
                    name="Settings"
                    children={() => <Settings />}/>
            </Tab.Navigator>
        );
    }
}