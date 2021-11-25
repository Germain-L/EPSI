import { createDrawerNavigator, DrawerItemList } from '@react-navigation/drawer';
import Article from "../../views/Article";
import Feed from "../../views/Feed";
import React from "react";
import { View, Image, SafeAreaView, Dimensions } from "react-native";
import Swiper from "./Swiper";
import Bottom from "./Bottom";

const winHeight = Dimensions.get('window').height;
const MyDrawer = createDrawerNavigator();

export default class Drawer extends React.Component {

    constructor(props) {
        super(props);
    }

    render() {
        return (
            <MyDrawer.Navigator
                drawerContent={(props) => {
                    return (
                        <SafeAreaView>
                            <View
                                style={{
                                    height: winHeight/3,
                                    alignItems: "center",
                                    justifyContent: "center",
                                    overflow: 'hidden',
                                    marginTop: winHeight/15,
                                    marginBottom: winHeight/20
                                }}
                            >
                                <Image
                                    source={require("../../assets/drawer.png")}
                                    style={{
                                        height: '100%',
                                        resizeMode: 'contain',
                                    }}
                                />
                            </View>
                            <DrawerItemList {...props} />
                        </SafeAreaView>
                    );
                }}
            >
                <MyDrawer.Screen
                    name="Feed"
                    children={() => <Feed test='Test' />}
                />
                <MyDrawer.Screen
                    name="Article"
                    children={() => <Article />}
                />
                <MyDrawer.Screen
                    name="Swiper"
                    children={() => <Swiper />}
                />
                <MyDrawer.Screen
                    name="Bottom"
                    children={() => <Bottom />}
                />
            </MyDrawer.Navigator>
        );
    }
}

