import React from 'react';
import {SafeAreaView, StyleSheet, Text, View} from 'react-native';

export default class App extends React.Component {
  styles = StyleSheet.create({
    container: {
      flex: 1,
      backgroundColor: '#fff',
      alignItems: 'center',
      justifyContent: 'center',
    },
  });

  render() {
    return (
      <SafeAreaView>
        <View style={this.styles.container}>
          <Text>Hello react native</Text>
        </View>
      </SafeAreaView>
    );
  }
}
